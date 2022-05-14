using System.Text.Json.Serialization;

namespace Untangle.Uvm;

public class AppMetric
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }
    
    [JsonPropertyName("counterValue")]
    public object CounterValue { get; set; }
    
    [JsonPropertyName("expert")]
    public bool Expert { get; set; }
    
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }
    
    [JsonPropertyName("timeValue")]
    public object TimeValue { get; set; }
    
    [JsonPropertyName("value")]
    public string Value { get; set; }
}