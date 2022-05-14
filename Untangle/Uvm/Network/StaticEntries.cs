using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class StaticEntries
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("list")]
    public List<DnsStaticEntry> List { get; set; }
}