// Non-nullable field is uninitialized
#pragma warning disable CS8618
// Unassigned field
#pragma warning disable CS0649

// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnassignedField.Global

using static UntangleApi.Classes.BaseClass;
using static UntangleApi.Classes.SkinClass;

namespace UntangleApi.Classes;

public class WebUiClass
{
    public class ResponseWebUi
    {
        public WebUi Result;
        public uint Id;
        // FixUps
    }

    public class WebUi
    {
        public ResultObject? MetricManager;
        public string? ServerSerialnumber;
        public ResultObject? AppManager;
        public ResultObject? UriManager;
        public ResultObject? SystemManager;
        public ResultObject? BrandingManager;
        public string? CompanyName;
        public string? RegionName;
        public int? TimeZoneOffset;
        public SkinSettings? SkinSettings;
        // AppViews
        public string? CompanyUrl;
        public string? ApplianceModel;
        public ResultObject? NotificationManager;
        public ResultObject? DashboardManager;
        public string? HostName;
        public Translations? Translations;
        public bool? IsExpertMode;
        public string? StoreUrl;
        public ResultObject? EventManager;
        public ResultObject? UserTable;
        public ResultObject? HostTable;
        public bool? SupportEnabled;
        public string? Architecture;
        public ResultObject? AdminManager;
        public ResultObject? ExecManager;
        // NetworkSettings
        public ResultObject? NetworkManager;
        public string? FullVersionAndRevision;
        public LanguageSettings? LanguageSettings;
        public string? HelpUrl;
        public string? Version;
        public ResultObject? LanguageManager;
        public ResultObject? AuthenticationManager;
        public string? FullVersion;
        public ResultObject? SkinManager;
        public SkinInfo? SkinInfo;
        public ResultObject? SessionMonitor;
        public ResultObject? SessionManager;
        public string? ServerUid;
        public string? InstallType;
        public bool? IsRegistered;
        public ResultObject? DeviceTable;
        public bool? ReportsEnabled;
    }
}