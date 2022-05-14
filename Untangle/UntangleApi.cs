// ReSharper disable PrivateFieldCanBeConvertedToLocalVariable
// ReSharper disable MemberCanBePrivate.Global

using System.Collections.Specialized;
using System.Text;
using System.Text.Json;
using Serilog;
using Untangle.Classes;
using Untangle.SupportClasses;
using static Untangle.Classes.Base;
using static Untangle.Classes.AdminSettingsClass;

namespace Untangle;

// ReSharper disable MemberCanBePrivate.Global

public class UntangleApi : IDisposable
{
    /// <summary>
    /// Used for internal classes to reference this
    /// </summary>
    internal static UntangleApi? Untangle;
    
    public Classes.Uvm Uvm;
    public AdminSettings? AdminSettings;
    
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
        Uvm = new Classes.Uvm();
        Untangle = this;
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
        
        if (!await GetSetupAsync())
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
            var responseBytes = await _client.UploadValuesTaskAsync(new Uri(_loginUri), values);
            var responseString = Encoding.Default.GetString(responseBytes);
            if (responseString == "0")
            {
                Log.Debug("Authenticated successfully");
                return true;
            }
            if (responseString.Contains("<!DOCTYPE html>"))
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
        _token = result.Result!;
        Log.Debug("Token retrieved");
        return true;
    }

    /// <summary>
    /// The main method to interact with untangle
    /// <br/><a href="https://apidocs.untangle.com">Documentation</a>
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
            request.Params = new[] { parameters };

        T response = default!;
        
        try
        {
            string jsonRequest = JsonSerializer.Serialize(request);
            string jsonResponse = await _client.UploadStringTaskAsync(_jsonRpcUri, jsonRequest);
            if (jsonResponse.Contains("\"error\""))
            {
                var error = JsonSerializer.Deserialize<ErrorResponse>(jsonResponse);
                // TODO Handle Error
                Log.Error("{Code}: {Msg}", error!.Error.Code, error.Error.Msg);
                return response;
            }
            response = JsonSerializer.Deserialize<T>(jsonResponse)!;
        }
        catch (Exception ex)
        {
            Log.Error(ex, "{Method}", method);
        }

        return response;
    }

    /// <summary>
    /// Retrieves the WebUi component
    /// </summary>
    private async Task<bool> GetWebUiAsync()
    {
        try
        {
            var response = await ExecuteAsync<WebUiResponse>("UvmContext.getWebuiStartupInfo");
            Uvm.MetricManager = response.Result.MetricManager;
            Uvm.ServerSerialnumber = response.Result.ServerSerialnumber;
            Uvm.AppManager = response.Result.AppManager;
            Uvm.UriManager = response.Result.UriManager;
            Uvm.SystemManager = response.Result.SystemManager;
            Uvm.BrandingManager = response.Result.BrandingManager;
            Uvm.CompanyName = response.Result.CompanyName;
            Uvm.RegionName = response.Result.RegionName;
            Uvm.TimeZoneOffset = response.Result.TimeZoneOffset;
            Uvm.SkinSettings = response.Result.SkinSettings;
            Uvm.AppsViews = response.Result.AppsViews;
            Uvm.CompanyUrl = response.Result.CompanyUrl;
            Uvm.ApplianceModel = response.Result.ApplianceModel;
            Uvm.NotificationManager = response.Result.NotificationManager;
            Uvm.DashboardManager = response.Result.DashboardManager;
            Uvm.Hostname = response.Result.Hostname;
            Uvm.Translations = response.Result.Translations;
            Uvm.IsExpertMode = response.Result.IsExpertMode;
            Uvm.StoreUrl = response.Result.StoreUrl;
            Uvm.EventManager = response.Result.EventManager;
            Uvm.UserTable = response.Result.UserTable;
            Uvm.HostTable = response.Result.HostTable;
            Uvm.SupportEnabled = response.Result.SupportEnabled;
            Uvm.Architecture = response.Result.Architecture;
            Uvm.AdminManager = response.Result.AdminManager;
            Uvm.ExecManager = response.Result.ExecManager;
            Uvm.NetworkSettings = response.Result.NetworkSettings;
            Uvm.NetworkManager = response.Result.NetworkManager;
            Uvm.FullVersionAndRevision = response.Result.FullVersionAndRevision;
            Uvm.LanguageSettings = response.Result.LanguageSettings;
            Uvm.HelpUrl = response.Result.HelpUrl;
            Uvm.Version = response.Result.Version;
            Uvm.LanguageManager = response.Result.LanguageManager;
            Uvm.AuthenticationManager = response.Result.AuthenticationManager;
            Uvm.FullVersion = response.Result.FullVersion;
            Uvm.SkinManager = response.Result.SkinManager;
            Uvm.SkinInfo = response.Result.SkinInfo;
            Uvm.SessionMonitor = response.Result.SessionMonitor;
            Uvm.SettingsManager = response.Result.SettingsManager;
            Uvm.ServerUid = response.Result.ServerUid;
            Uvm.InstallType = response.Result.InstallType;
            Uvm.IsRegistered = response.Result.IsRegistered;
            Uvm.DeviceTable = response.Result.DeviceTable;
            Uvm.ReportsEnabled = response.Result.ReportsEnabled;
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
    /// Retrieves the local Setup component
    /// </summary>
    private async Task<bool> GetSetupAsync()
    {
        try
        {
            var response = await ExecuteAsync<SetupResponse>("UvmContext.getSetupStartupInfo");
            Uvm.AdminManager = response.Result.AdminManager;
            Uvm.ConnectivityTester = response.Result.ConnectivityTester;
            Uvm.MailSender = response.Result.MailSender;
            Uvm.NetworkManager = response.Result.NetworkManager;
            Uvm.SystemManager = response.Result.SystemManager;
            Log.Debug("Setup retrieved");
            return true;
        }
        catch
        {
            Log.Error("Setup failed");
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
                $".obj#{Uvm!.AdminManager.ObjectId}.getSettings");
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
    /// Applies local changes to remote
    /// <br/><a href="https://apidocs.untangle.com">Documentation</a>
    /// </summary>
    /// <param name="obj">The object to be serialized</param>
    /// <param name="objectId">WebUi ObjectId</param>
    /// <param name="className">Name for the log</param>
    public static async Task ApplyAsync(Object obj, int objectId, string className)
    {
        var response = await Untangle?.ExecuteAsync<ResponseString>(
            $".obj#{objectId}.setSettings",
            obj)!;
        // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
        if (response is not null)
            Log.Information("Apply: {Name}", className);
        else
            Log.Error("Apply: {Name}", className);
    }

    public void Dispose()
    {
        _client.Dispose();
    }
}