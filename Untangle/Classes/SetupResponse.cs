using System.Text.Json.Serialization;

namespace Untangle.Classes;

public class SetupResponse
{
    [JsonPropertyName("result")]
    public Setup Result { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }
}