using System.Text.Json.Serialization;

namespace Untangle.Uvm;

public class UserTable
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("JSONRPCType")]
    public string JsonRpcType { get; set; }

    [JsonPropertyName("objectID")]
    public int ObjectID { get; set; }
}