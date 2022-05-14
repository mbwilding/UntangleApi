using System.Text.Json.Serialization;

namespace Untangle.Classes;

public class WebUiResponse
{
    [JsonPropertyName("result")]
    public WebUi Result { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("fixups")]
    public List<List<List<object>>> FixUps { get; set; }
}