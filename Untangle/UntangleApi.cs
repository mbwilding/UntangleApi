// ReSharper disable PrivateFieldCanBeConvertedToLocalVariable
// ReSharper disable MemberCanBePrivate.Global

using System.Collections.Specialized;
using System.Net;
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
    /// <param name="ssl">Enable if Untangle is using HTTPS/SSL</param>
    /// <param name="logger">Enable if you want console feedback from this API</param>
    public UntangleApi(string host, string username, string password, bool ssl = false, bool logger = true)
    {
        if (logger)
            Logging();
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
            IncludeFields = true,
            //DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        };
    }

    /// <summary>
    /// Initializes Serilog
    /// </summary>
    private void Logging()
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Verbose()
            .WriteTo.Console()
            .CreateLogger();
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
        
        if (!await GetWebUi())
            return false;
        
        if (!await GetAdminSettings())
            return false;

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
    private async Task<bool> GetWebUi()
    {
        try
        {
            var response = await ExecuteAsync<ResponseWebUi>("UvmContext.getWebuiStartupInfo");
            WebUi = response.Result;
            Log.Debug("GetWebUiIds retrieved");
            return true;
        }
        catch
        {
            Log.Error("GetWebUiIds failed");
            return false;
        }
    }
    
    /// <summary>
    /// Retrieves and sets the local AdminSettings component
    /// </summary>
    private async Task<bool> GetAdminSettings()
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