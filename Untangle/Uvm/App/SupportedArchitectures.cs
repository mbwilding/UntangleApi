using System.Text.Json.Serialization;

namespace Untangle.Uvm.App;

public class SupportedArchitectures
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("list")]
    public List<string> List { get; set; }
}