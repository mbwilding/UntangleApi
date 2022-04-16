//Non-nullable field is uninitialized
#pragma warning disable CS8618
// Non-accessed field
#pragma warning disable CS0414
// Unassigned field
#pragma warning disable CS0649

// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnassignedField.Global

namespace Untangle.Classes;

public class AppsViewsClass
{
    public class AppsView
    {
        public LicenseMap LicenseMap;
        public uint PolicyId;
        public Instances Instances;
        public string JavaClass;
        public AppMetrics AppMetrics;
        public Installable Installable;
        public RunStates RunStates;
        public AppProperties AppProperties;
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

public class Instances
{
    public string JavaClass;
    public List<AppSettings> List;
}

public class AppSettings
{
    public uint? PolicyId;
    public string JavaClass;
    public string AppName;
    public string? TargetState;
    public uint Id;
}

public class AppMetrics
{
    public string JavaClass;
    public Dictionary<string, AppMetricMap> Map;
}

public class AppMetricMap
{
    public string JavaClass;
    public List<AppMetric> List;
}

public class AppMetric
{
    public uint? CounterValue;
    public bool Expert;
    public string JavaClass;
    public string DisplayName;
    public string Name;
    public string? DisplayUnits;
    public uint? TimeValue;
    public string? Type;
    public uint Value;
}

public class Installable
{
    public string JavaClass;
    public List<string> List;
}

public class RunStates
{
    public string JavaClass;
    // TODO Update from object only seen an empty map in the JSON
    public Dictionary<string, object> Map;
}

public class AppProperties
{
    public string JavaClass;
    public List<AppProperty> List;
}

public class AppProperty
{
    public string JavaClass;
    public string DisplayName;
    public bool AutoLoad;
    public bool Invisible;
    public ulong? MinimumMemory;
    public string ClassName;
    public uint ViewPosition;
    public string? Type;
    public bool HasPowerButton;
    public bool AutoInstall;
    public bool AutoStart;
    public string? Daemon;
    public string AppBase;
    public SupportedArchitectures SupportedArchitectures;
    public uint AutoInstallMinMemory;
    public uint AutoInstallMinRequireInterfaces;
    public string Name;
    public Parents Parents;
}

public class SupportedArchitectures
{
    public string JavaClass;
    public List<string> List;
}

public class Parents
{
    public string JavaClass;
    public List<string> List;
}