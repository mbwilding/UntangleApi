using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class NetflowSettings
{
    [JsonPropertyName("port")]
    public int Port { get; set; }

    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("host")]
    public string Host { get; set; }

    [JsonPropertyName("version")]
    public int Version { get; set; }

    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}