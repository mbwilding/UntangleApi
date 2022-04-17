// ReSharper disable PrivateFieldCanBeConvertedToLocalVariable
// ReSharper disable MemberCanBePrivate.Global

using System.Collections.Specialized;
using System.Text;
using System.Text.Json;
using Serilog;
using Untangle.SupportClasses;
using static Untangle.Classes.Base;
using static Untangle.Classes.WebUiClass;
using static Untangle.Classes.AdminSettingsClass;

namespace Untangle;

public class UntangleApi : IDisposable
{
    // ReSharper disable once MemberCanBePrivate.Global
    public WebUi? WebUi;
    public AdminSettings? AdminSettings;

    private readonly JsonSerializerOptions _jsonOptions;
    private readonly CookieWebClient _client;
    private readonly bool _ssl;
    private readonly string _host;
    private readonly string _username;
    private readonly string _password;
    private readonly string _uri;
    private readonly string _loginUri;
    private readonly string _adminUri;
    private readonly string _jsonRpcUri;
    private string _token = string.Empty;
    private int _requestCount;

    /// <summary>
    /// The main class to work with UntangleAPI
    /// </summary>
    /// <param name="host">Can be an IP or HostName, can append with a custom port using ':'</param>
    /// <param name="username">Username</param>
    /// <param name="password">Password</param>
    /// <param name="ssl">HTTPS/SSL</param>
    /// <param name="logger">Console logging from this API</param>
    /// <param name="loggerVerbose">Verbose console logging</param>
    public UntangleApi(string host,string username, string password, bool ssl = false, bool logger = true, bool loggerVerbose = true)
    {
        if (logger)
            Logging.Init(loggerVerbose);
        _client = new CookieWebClient();
        _ssl = ssl;
        _host = host;
        _username = username;
        _password = password;
        _uri = $"http{(_ssl ? "s" : "")}://{_host}";
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

    /// <summary>
    /// Authenticates and saves the cookie for the WebClient
    /// </summary>
    public async Task<bool> StartAsync()
    {
        if (!await GetAuthAsync())
            return false;
        
        if (!await GetTokenAsync())
            return false;
        
        Log.Information("Connected");
        
        if (!await GetWebUiAsync())
            return false;
        
        if (!await GetAdminSettingsAsync())
            return false;
        
        Log.Information("Ready");

        return true;
    }

    /// <summary>
    /// Authenticates and saves the cookie for the WebClient
    /// </summary>
    private async Task<bool> GetAuthAsync()
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
            var responseJson = Encoding.Default.GetString(response);
            if (responseJson == "0")
            {
                Log.Debug("Authenticated succesfully");
                return true;
            }
            if (responseJson.Contains("<!DOCTYPE html>"))
            {
                Log.Error("Check username and password");
                return false;
            }
        }
        catch (Exception ex)
        {
            Log.Error(ex, "{Error}", ex.InnerException);
        }

        return false;
    }

    /// <summary>
    /// Retrieves and sets the token used by all transactions through Execute
    /// </summary>
    private async Task<bool> GetTokenAsync()
    {
        _client.Headers.Remove("Content-Type");
        _client.Headers.Add("Content-Type", "application/json");
        
        var result = await ExecuteAsync<ResponseString>("system.getNonce");
        _token = result.Result;
        Log.Debug("Token retrieved");
        return true;
    }

    /// <summary>
    /// The main method to interact with untangle
    /// </summary>
    /// <param name="method">The item being requested, preceded by an object identifier</param>
    /// <param name="parameters">The object to be serialised and sent, used when doing a set</param>
    // ReSharper disable once MemberCanBePrivate.Global
    public async Task<T> ExecuteAsync<T>(string method, object parameters = null!)
    {
        int id = Interlocked.Increment(ref _requestCount);
        var request = new Request{ Method = method, Nonce = _token, Id = id, Params = Array.Empty<string>() };
        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (parameters is not null)
            request.Params = new[] {parameters};

        T response = default!;
        
        try
        {
            string jsonRequest = JsonSerializer.Serialize(request, _jsonOptions);
            string jsonResponse = await _client.UploadStringTaskAsync(_jsonRpcUri, jsonRequest);
            if (jsonResponse.Contains("\"error\""))
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

    /// <summary>
    /// Retrieves and sets the local WebUi component
    /// </summary>
    private async Task<bool> GetWebUiAsync()
    {
        try
        {
            var response = await ExecuteAsync<ResponseWebUi>("UvmContext.getWebuiStartupInfo");
            WebUi = response.Result;
            Log.Debug("WebUi retrieved");
            return true;
        }
        catch
        {
            Log.Error("WebUi failed");
            return false;
        }
    }
    
    /// <summary>
    /// Retrieves and sets the local AdminSettings component
    /// </summary>
    private async Task<bool> GetAdminSettingsAsync()
    {
        try
        {
            var response = await ExecuteAsync<AdminSettingsResponse>(
                $".obj#{WebUi!.AdminManager.ObjectId}.getSettings");
            AdminSettings = response.Result;
            Log.Debug("AdminSettings retrieved");
            return true;
        }
        catch
        {
            Log.Error("AdminSettings failed");
            return false;
        }
    }
    
    /// <summary>
    /// Sets the remote AdminSettings from local
    /// </summary>
    public async Task<bool> SetAdminSettingsAsync()
    {
        try
        {
            var response = await ExecuteAsync<ResponseString>(
                $".obj#{WebUi!.AdminManager.ObjectId}.setSettings",
                AdminSettings!);
            Log.Debug("AdminSettings set");
            return true;
        }
        catch
        {
            Log.Error("AdminSettings failed");
            return false;
        }
    }

    public void Dispose()
    {
        _client.Dispose();
    }
}