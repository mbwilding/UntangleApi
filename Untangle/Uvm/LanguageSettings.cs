using System.Text.Json.Serialization;

namespace Untangle.Uvm;

public class LanguageSettings
{
    [JsonPropertyName("overrideDateFmt")]
    public string OverrideDateFmt { get; set; }

    [JsonPropertyName("overrideTimestampFmt")]
    public string OverrideTimestampFmt { get; set; }

    [JsonPropertyName("lastSynchronized")]
    public int LastSynchronized { get; set; }

    [JsonPropertyName("overrideDecimalSep")]
    public string OverrideDecimalSep { get; set; }

    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("language")]
    public string Language { get; set; }

    [JsonPropertyName("regionalFormats")]
    public string RegionalFormats { get; set; }

    [JsonPropertyName("overrideThousandSep")]
    public string OverrideThousandSep { get; set; }

    [JsonPropertyName("source")]
    public string Source { get; set; }
}