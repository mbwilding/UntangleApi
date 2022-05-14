using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class FilterRuleConditions
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("list")]
    public List<FilterRuleCondition> List { get; set; }
}