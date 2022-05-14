using System.Text.Json.Serialization;
using Untangle.Uvm.App;

namespace Untangle.Uvm;

public class AppsView
{
    [JsonPropertyName("licenseMap")]
    public LicenseMap LicenseMap { get; set; }

    [JsonPropertyName("policyId")]
    public int PolicyId { get; set; }

    [JsonPropertyName("instances")]
    public Instances Instances { get; set; }

    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("appMetrics")]
    public AppMetrics AppMetrics { get; set; }

    [JsonPropertyName("installable")]
    public Installable Installable { get; set; }

    [JsonPropertyName("runStates")]
    public RunStates RunStates { get; set; }

    [JsonPropertyName("appProperties")]
    public AppProperties AppProperties { get; set; }
}