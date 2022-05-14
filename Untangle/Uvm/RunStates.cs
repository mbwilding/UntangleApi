using System.Text.Json.Serialization;

namespace Untangle.Uvm;

public class RunStates
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    // TODO Empty
    [JsonPropertyName("map")]
    public object Map { get; set; }
}