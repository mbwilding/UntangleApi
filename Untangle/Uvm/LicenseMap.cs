using System.Text.Json.Serialization;

namespace Untangle.Uvm;

public class LicenseMap
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("map")]
    public License Map { get; set; }
}