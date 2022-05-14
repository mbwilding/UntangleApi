using System.Text.Json.Serialization;

namespace Untangle.Uvm.App;

public class Instances
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("list")]
    public List<AppSettings> List { get; set; }
}