using System.Text.Json.Serialization;

namespace Untangle.Uvm;

public class Installable
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("list")]
    public List<string> List { get; set; }
}