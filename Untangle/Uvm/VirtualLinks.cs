using System.Text.Json.Serialization;

namespace Untangle.Uvm;

public class VirtualLinks
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("list")] // TODO
    public List<object> List { get; set; }
}