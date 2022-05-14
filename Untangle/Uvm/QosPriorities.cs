using System.Text.Json.Serialization;

namespace Untangle.Uvm;

public class QosPriorities
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("list")]
    public List<List> List { get; set; }
}