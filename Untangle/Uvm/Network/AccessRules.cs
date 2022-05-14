using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class AccessRules
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("list")]
    public List<FilterRule> List { get; set; }
}