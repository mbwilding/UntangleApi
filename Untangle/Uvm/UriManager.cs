using System.Text.Json.Serialization;

namespace Untangle.Uvm;

public class UriManager
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("JSONRPCType")]
    public string JsonRpcType { get; set; }

    [JsonPropertyName("objectID")]
    public int ObjectID { get; set; }
}