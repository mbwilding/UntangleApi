using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class DynamicRouteOspfArea
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("area")]
    public string Area { get; set; }
    
    [JsonPropertyName("description")]
    public string Description { get; set; }
    
    [JsonPropertyName("virtualLinks")]
    public VirtualLinks VirtualLinks { get; set; }
    
    [JsonPropertyName("ruleId")]
    public int RuleId { get; set; }
    
    [JsonPropertyName("type")]
    public int Type { get; set; }
    
    [JsonPropertyName("authentication")]
    public int Authentication { get; set; }
}