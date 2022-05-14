using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class StaticRoutes
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("list")]
    public List<object> List { get; set; }
}