using System.Text.Json.Serialization;

namespace Untangle.Uvm;

public class _32
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("list")]
    public List<List> List { get; set; }
}