using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class DnsStaticEntry
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("address")]
    public string Address { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }
}