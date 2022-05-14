using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class BypassRules
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("list")]
    public List<BypassRule> List { get; set; }
}