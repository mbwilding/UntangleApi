using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class Interfaces
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("list")]
    public List<InterfaceSettings> List { get; set; }
}