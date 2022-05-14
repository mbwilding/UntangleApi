using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class DnsSettings
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("staticEntries")]
    public StaticEntries StaticEntries { get; set; }

    [JsonPropertyName("localServers")]
    public LocalServers LocalServers { get; set; }
}