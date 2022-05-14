using System.Text.Json.Serialization;

namespace Untangle.Uvm.App;

public class AppProperties
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("list")]
    public List<AppProperty> List { get; set; }
}