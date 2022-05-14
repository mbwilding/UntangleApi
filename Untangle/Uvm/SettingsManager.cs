using System.Text.Json.Serialization;

namespace Untangle.Uvm;

public class SettingsManager
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("JSONRPCType")]
    public string JSONRPCType { get; set; }

    [JsonPropertyName("objectID")]
    public int ObjectID { get; set; }
}