using System.Text.Json.Serialization;
using Untangle.Uvm;
using Untangle.Uvm.Network;

namespace Untangle.Classes;

public class Uvm
{
    [JsonPropertyName("metricManager")]
    public MetricManager? MetricManager { get; set; }

    [JsonPropertyName("serverSerialnumber")]
    public string? ServerSerialnumber { get; set; }

    [JsonPropertyName("appManager")]
    public AppManager? AppManager { get; set; }

    [JsonPropertyName("uriManager")]
    public UriManager? UriManager { get; set; }

    [JsonPropertyName("systemManager")]
    public SystemManager? SystemManager { get; set; }

    [JsonPropertyName("brandingManager")]
    public BrandingManager? BrandingManager { get; set; }

    [JsonPropertyName("companyName")]
    public string? CompanyName { get; set; }

    [JsonPropertyName("regionName")]
    public string? RegionName { get; set; }

    [JsonPropertyName("timeZoneOffset")]
    public int? TimeZoneOffset { get; set; }

    [JsonPropertyName("skinSettings")]
    public SkinSettings? SkinSettings { get; set; }

    [JsonPropertyName("appsViews")]
    public List<AppsView>? AppsViews { get; set; }

    [JsonPropertyName("companyURL")]
    public string? CompanyUrl { get; set; }

    [JsonPropertyName("applianceModel")]
    public string? ApplianceModel { get; set; }

    [JsonPropertyName("notificationManager")]
    public NotificationManager? NotificationManager { get; set; }

    [JsonPropertyName("dashboardManager")]
    public DashboardManager? DashboardManager { get; set; }

    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    [JsonPropertyName("translations")]
    public Translations? Translations { get; set; }

    [JsonPropertyName("isExpertMode")]
    public bool? IsExpertMode { get; set; }

    [JsonPropertyName("storeUrl")]
    public string? StoreUrl { get; set; }

    [JsonPropertyName("eventManager")]
    public EventManager? EventManager { get; set; }

    [JsonPropertyName("userTable")]
    public UserTable? UserTable { get; set; }

    [JsonPropertyName("hostTable")]
    public HostTable? HostTable { get; set; }

    [JsonPropertyName("supportEnabled")]
    public bool? SupportEnabled { get; set; }

    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    [JsonPropertyName("adminManager")]
    public AdminManager? AdminManager { get; set; }

    [JsonPropertyName("execManager")]
    public ExecManager? ExecManager { get; set; }

    [JsonPropertyName("networkSettings")]
    public NetworkSettings? NetworkSettings { get; set; }

    [JsonPropertyName("networkManager")]
    public NetworkManager? NetworkManager { get; set; }

    [JsonPropertyName("fullVersionAndRevision")]
    public string? FullVersionAndRevision { get; set; }

    [JsonPropertyName("languageSettings")]
    public LanguageSettings? LanguageSettings { get; set; }

    [JsonPropertyName("helpUrl")]
    public string? HelpUrl { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }

    [JsonPropertyName("languageManager")]
    public LanguageManager? LanguageManager { get; set; }

    [JsonPropertyName("authenticationManager")]
    public AuthenticationManager? AuthenticationManager { get; set; }

    [JsonPropertyName("fullVersion")]
    public string? FullVersion { get; set; }

    [JsonPropertyName("skinManager")]
    public SkinManager? SkinManager { get; set; }

    [JsonPropertyName("skinInfo")]
    public SkinInfo? SkinInfo { get; set; }

    [JsonPropertyName("sessionMonitor")]
    public SessionMonitor? SessionMonitor { get; set; }

    [JsonPropertyName("settingsManager")]
    public SettingsManager? SettingsManager { get; set; }

    [JsonPropertyName("serverUID")]
    public string? ServerUid { get; set; }

    [JsonPropertyName("installType")]
    public string? InstallType { get; set; }

    [JsonPropertyName("isRegistered")]
    public bool? IsRegistered { get; set; }

    [JsonPropertyName("deviceTable")]
    public DeviceTable? DeviceTable { get; set; }

    [JsonPropertyName("reportsEnabled")]
    public bool? ReportsEnabled { get; set; }
    
    [JsonPropertyName("connectivityTester")]
    public ConnectivityTester? ConnectivityTester { get; set; }

    [JsonPropertyName("mailSender")]
    public MailSender? MailSender { get; set; }
}