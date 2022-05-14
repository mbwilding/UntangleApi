using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class StaticDhcpEntries
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("list")]
    public List<StaticDhcpEntry> List { get; set; }
}