using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class UpnpSettings
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("upnpRules")]
    public UpnpRules UpnpRules { get; set; }

    [JsonPropertyName("listenPort")]
    public int ListenPort { get; set; }

    [JsonPropertyName("secureMode")]
    public bool SecureMode { get; set; }

    [JsonPropertyName("upnpEnabled")]
    public bool UpnpEnabled { get; set; }
}