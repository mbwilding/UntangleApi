using System.Text.Json.Serialization;

namespace Untangle.Uvm;

public class AppMetrics
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("map")]
    public AppMetric Map { get; set; }
}