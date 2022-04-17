// Non-nullable field is uninitialized
#pragma warning disable CS8618
// Non-accessed field
#pragma warning disable CS0414
// Unassigned field
#pragma warning disable CS0649

// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnassignedField.Global

using static Untangle.Classes.Base;
using static Untangle.Classes.Skin;
using static Untangle.Classes.AppsViewsClass;

namespace Untangle.Classes;

public class WebUiClass
{
    public class ResponseWebUi
    {
        public WebUi Result;
        public uint Id;
        // TODO FixUps
    }

    public class WebUi
    {
        public ResponseObject MetricManager;
        public string ServerSerialnumber;
        public ResponseObject AppManager;
        public ResponseObject UriManager;
        public ResponseObject SystemManager;
        public ResponseObject BrandingManager;
        public string CompanyName;
        public string RegionName;
        public int TimeZoneOffset;
        public SkinSettings SkinSettings;
        public List<AppsView> AppsViews;
        public string CompanyUrl;
        public string ApplianceModel;
        public ResponseObject NotificationManager;
        public ResponseObject DashboardManager;
        public string HostName;
        public Translations Translations;
        public bool IsExpertMode;
        public string StoreUrl;
        public ResponseObject EventManager;
        public ResponseObject UserTable;
        public ResponseObject HostTable;
        public bool SupportEnabled;
        public string Architecture;
        public ResponseObject AdminManager;
        public ResponseObject ExecManager;
        public NetworkSettings NetworkSettings;
        public ResponseObject NetworkManager;
        public string FullVersionAndRevision;
        public LanguageSettings LanguageSettings;
        public string HelpUrl;
        public string Version;
        public ResponseObject LanguageManager;
        public ResponseObject AuthenticationManager;
        public string FullVersion;
        public ResponseObject SkinManager;
        public SkinInfo SkinInfo;
        public ResponseObject SessionMonitor;
        public ResponseObject SessionManager;
        public string ServerUid;
        public string InstallType;
        public bool IsRegistered;
        public ResponseObject DeviceTable;
        public bool ReportsEnabled;
    }
}