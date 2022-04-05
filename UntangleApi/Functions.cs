using System.Collections.Specialized;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using static UntangleApi.Exchange;

namespace UntangleApi;

public class UntangleApi : IDisposable
{
    private JsonSerializerOptions _jsonOptions;
    private CookieWebClient _client;
    private readonly bool _https;
    private readonly string _ipPort;
    private readonly string _username;
    private readonly string _password;
    private readonly string _uri;
    private readonly string _loginUri;
    private readonly string _adminUri;
    private readonly string _jsonRpcUri;
    private string _token;

    public UntangleApi(string ipPort, string username, string password, bool https = true)
    {
        _client = new CookieWebClient();
        _https = https;
        _ipPort = ipPort;
        _username = username;
        _password = password;
        _uri = $"http{(_https ? "s" : "")}://{_ipPort}";
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

    public async Task<bool> LoginAsync()
    {
        if (!await AuthenticationAsync())
            return false;
        return await GetAuthenticationToken();
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
                Console.WriteLine("Authenticated");
                return true;
            }

            Console.WriteLine("Invalid response");
            return false;

        }
        catch (WebException ex)
        {
            Console.WriteLine("Failed authentication");
        }

        return false;
    }

    private async Task<bool> GetAuthenticationToken()
    {
        try
        {
            _client.Headers.Remove("Content-Type");
            _client.Headers.Add("Content-Type", "application/json");
            string jsonRequest = JsonSerializer.Serialize(new GetAuthenticationTokenRequest(), _jsonOptions);
            string jsonResponse = await _client.UploadStringTaskAsync(_jsonRpcUri, jsonRequest);
            if (jsonResponse.Contains("{\"error\":"))
            {
                var error = JsonSerializer.Deserialize<ErrorResponse>(jsonResponse, _jsonOptions);
                // TODO Handle Error
                Console.WriteLine($"Error: [{error.Error.Code}] {error.Error.Msg}");
                return false;
            }
            var tokenObject = JsonSerializer.Deserialize<GetAuthenticationTokenResponse>(jsonResponse, _jsonOptions);
            _token = tokenObject!.Result;
            Console.WriteLine("Token set");
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Failed token");
        }

        return false;
    }
    
    public void Dispose()
    {
        _client.Dispose();
    }
}