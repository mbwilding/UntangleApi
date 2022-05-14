using System.Text.Json.Serialization;

namespace Untangle.Uvm;

public class V6Aliases
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("list")]
    public List<object> List { get; set; }
}