using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class VirtualInterfaces
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("list")]
    public List<List> List { get; set; }
}