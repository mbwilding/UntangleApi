using System.Text.Json.Serialization;

namespace Untangle.Uvm;

public class ConnectivityTester
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("JSONRPCType")]
    public string JsonRpcType { get; set; }

    [JsonPropertyName("objectID")]
    public int ObjectId { get; set; }
}