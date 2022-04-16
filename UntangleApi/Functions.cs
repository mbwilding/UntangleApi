﻿using System.Collections.Specialized;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using Serilog;
using static UntangleApi.Exchange;

namespace UntangleApi;

public class UntangleApi : IDisposable
{
    private JsonSerializerOptions _jsonOptions;
    private CookieWebClient _client;
    private readonly bool _ssl;
    private readonly string _ipPort;
    private readonly string _username;
    private readonly string _password;
    private readonly string _uri;
    private readonly string _loginUri;
    private readonly string _adminUri;
    private readonly string _jsonRpcUri;
    private string _token = string.Empty;
    private uint _appManagerId;

    public UntangleApi(string ipPort, string username, string password, bool ssl = true, bool logger = true)
    {
        if (logger)
            Logging();
        _client = new CookieWebClient();
        _ssl = ssl;
        _ipPort = ipPort;
        _username = username;
        _password = password;
        _uri = $"http{(_ssl ? "s" : "")}://{_ipPort}";
        _loginUri = $"{_uri}/auth/login";
        _adminUri = $"{_uri}/admin";
        _jsonRpcUri = $"{_adminUri}/JSON-RPC";
        _jsonOptions = new JsonSerializerOptions
        {
            DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = false,
            PropertyNameCaseInsensitive = true,
            IncludeFields = true
        };
    }

    private void Logging()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Verbose()
            .WriteTo.Console()
            .CreateLogger();
    }

    public async Task<bool> StartAsync()
    {
        if (!await AuthenticationAsync())
            return false;
        
        if (!await GetAuthenticationToken())
            return false;
        
        if (!await GetAppManagerId())
            return false;

        return true;
    }
    
    private async Task<bool> AuthenticationAsync()
    {
        _client.Headers.Remove("Content-Type");
        var values = new NameValueCollection
        {
            ["username"] = _username,
            ["password"] = _password
        };

        try
        {
            _client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            var response = await _client.UploadValuesTaskAsync(new Uri(_loginUri), values);

            if (Encoding.Default.GetString(response) == "0")
            {
                Log.Debug("Authenticated");
                return true;
            }

            Log.Error("Invalid response");
            return false;

        }
        catch (WebException)
        {
            Log.Error("Failed authentication");
        }

        return false;
    }

    private async Task<bool> GetAuthenticationToken()
    {
        _client.Headers.Remove("Content-Type");
        _client.Headers.Add("Content-Type", "application/json");
        
        var result = await Execute<ResponseString>("system.getNonce");
        _token = result.Result;
        Log.Debug("Token: {Token}", _token);
        return true;
    }

    public async Task<T> Execute<T>(string method, string[]? parameters = null)
    {
        var request = new Request{ Method = method, Nonce = _token};
        if (parameters is not null)
            request.Params = parameters;

        T response = default!;
        
        try
        {
            string jsonRequest = JsonSerializer.Serialize(request, _jsonOptions);
            string jsonResponse = await _client.UploadStringTaskAsync(_jsonRpcUri, jsonRequest);
            if (jsonResponse.Contains("error"))
            {
                var error = JsonSerializer.Deserialize<ErrorResponse>(jsonResponse, _jsonOptions);
                // TODO Handle Error
                Log.Error("{Code}: {Msg}", error!.Error.Code, error.Error.Msg);
                return response;
            }
            response = JsonSerializer.Deserialize<T>(jsonResponse, _jsonOptions)!;
        }
        catch (Exception ex)
        {
            Log.Error(ex, "{Method}", method);
        }

        return response;
    }

    public async Task<bool> GetAppManagerId()
    {
        try
        {
            var response = await Execute<ResponseObject>("UvmContext.appManager");
            _appManagerId = response.Result.ObjectId;
            Log.Debug("AppManagerId: {Id}", _appManagerId);
            return true;
        }
        catch
        {
            Log.Error("AppManagerId not set");
            return false;
        }
    }
    
    public async Task<string> GetWebuiStartupInfo() => await Execute<string>("UvmContext.getWebuiStartupInfo"); // TODO

    public void Dispose()
    {
        _client.Dispose();
    }
}