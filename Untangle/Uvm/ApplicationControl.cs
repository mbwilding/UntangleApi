using System.Text.Json.Serialization;

namespace Untangle.Uvm;

public class ApplicationControl
{
    [JsonPropertyName("daysRemaining")]
    public int DaysRemaining { get; set; }

    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    [JsonPropertyName("start")]
    public int Start { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("seats")]
    public int Seats { get; set; }

    [JsonPropertyName("trial")]
    public bool Trial { get; set; }

    [JsonPropertyName("valid")]
    public bool Valid { get; set; }

    [JsonPropertyName("UID")]
    public string UID { get; set; }

    [JsonPropertyName("expired")]
    public bool Expired { get; set; }

    [JsonPropertyName("keyVersion")]
    public int KeyVersion { get; set; }

    [JsonPropertyName("seatsDisplay")]
    public string SeatsDisplay { get; set; }

    [JsonPropertyName("currentName")]
    public string CurrentName { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("end")]
    public int End { get; set; }

    [JsonPropertyName("key")]
    public string Key { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }
}