using System.Text.Json.Serialization;

namespace Untangle.Uvm.App;

public class AppProperty
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }
    
    [JsonPropertyName("autoLoad")]
    public bool AutoLoad { get; set; }

    [JsonPropertyName("invisible")]
    public bool Invisible { get; set; }

    [JsonPropertyName("minimumMemory")]
    public int? MinimumMemory { get; set; }

    [JsonPropertyName("className")]
    public string ClassName { get; set; }

    [JsonPropertyName("viewPosition")]
    public int ViewPosition { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("hasPowerButton")]
    public bool HasPowerButton { get; set; }

    [JsonPropertyName("autoInstall")]
    public bool AutoInstall { get; set; }

    [JsonPropertyName("autoStart")]
    public bool AutoStart { get; set; }

    [JsonPropertyName("daemon")]
    public string Daemon { get; set; }

    [JsonPropertyName("appBase")]
    public string AppBase { get; set; }

    [JsonPropertyName("supportedArchitectures")]
    public SupportedArchitectures SupportedArchitectures { get; set; }

    [JsonPropertyName("autoInstallMinMemory")]
    public int AutoInstallMinMemory { get; set; }

    [JsonPropertyName("autoInstallMinRequireInterfaces")]
    public int AutoInstallMinRequireInterfaces { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("parents")]
    public Parents Parents { get; set; }
}