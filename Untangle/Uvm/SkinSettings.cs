using System.Text.Json.Serialization;

namespace Untangle.Uvm;

public class SkinSettings
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("skinName")]
    public string SkinName { get; set; }
}