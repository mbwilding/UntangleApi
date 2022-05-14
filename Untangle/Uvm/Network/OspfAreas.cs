using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class OspfAreas
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("list")]
    public List<DynamicRouteOspfArea> List { get; set; }
}