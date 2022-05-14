using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class StaticDhcpEntry
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("macAddress")]
    public string MacAddress { get; set; }
    
    [JsonPropertyName("address")]
    public string Address { get; set; }
    
    [JsonPropertyName("description")]
    public string Description { get; set; }
}