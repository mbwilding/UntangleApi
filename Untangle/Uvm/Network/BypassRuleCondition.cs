using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class BypassRuleCondition
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("invert")]
    public bool Invert { get; set; }
    
    [JsonPropertyName("conditionType")]
    public string ConditionType { get; set; }
    
    [JsonPropertyName("value")]
    public string Value { get; set; }
}