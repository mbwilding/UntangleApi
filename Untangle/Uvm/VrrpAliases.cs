using System.Text.Json.Serialization;

namespace Untangle.Uvm;

public class VrrpAliases
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("list")]
    public List<object> List { get; set; }
}