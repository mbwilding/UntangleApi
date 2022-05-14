using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class FilterRule
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("blocked")]
    public bool Blocked { get; set; }
    
    [JsonPropertyName("description")]
    public string Description { get; set; }
    
    [JsonPropertyName("readOnly")]
    public bool ReadOnly { get; set; }
    
    [JsonPropertyName("ipv6Enabled")]
    public bool Ipv6Enabled { get; set; }
    
    [JsonPropertyName("ruleId")]
    public int RuleId { get; set; }

    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
    
    [JsonPropertyName("conditions")]
    public FilterRuleConditions Conditions { get; set; }
}