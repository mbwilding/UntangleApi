using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class PortForwardRules
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("list")]
    public List<List> List { get; set; }
}