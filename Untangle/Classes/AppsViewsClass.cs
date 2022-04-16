//Non-nullable field is uninitialized
#pragma warning disable CS8618

namespace Untangle.Classes;

public class AppsViewsClass
{
    public class AppsViews
    {
        public LicenseMap LicenseMap;
        public uint PolicyId;
    }

    public class LicenseMap
    {
        public string JavaClass;
        public Dictionary<string, App> Map;
    }

    public class App
    {
        public uint DaysRemaining;
        public string JavaClass;
        public string DisplayName;
        public ulong Start;
        public string Type;
        public uint Seats;
        public bool Trial;
        public bool Valid;
        public string Uid;
        public bool Expired;
        public uint KeyVersion;
        public string SeatsDisplay;
        public string CurrentName;
        public string Name;
        public ulong End;
        public string Key;
        public string Status;
    }
}