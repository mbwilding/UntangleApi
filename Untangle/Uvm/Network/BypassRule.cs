using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class BypassRule
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("bypass")]
    public bool Bypass { get; set; }
    
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("ruleId")]
    public int RuleId { get; set; }

    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    [JsonPropertyName("conditions")]
    public BypassRuleCondition Conditions { get; set; }
}