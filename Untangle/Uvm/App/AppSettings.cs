using System.Text.Json.Serialization;

namespace Untangle.Uvm.App;

public class AppSettings
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("policyId")]
    public int? PolicyId { get; set; }
    
    [JsonPropertyName("appName")]
    public string AppName { get; set; }
    
    [JsonPropertyName("targetState")]
    public string TargetState { get; set; }
    
    [JsonPropertyName("id")]
    public int Id { get; set; }
}