using System.Text.Json.Serialization;

namespace Untangle.Uvm;

public class Translations
{
    [JsonPropertyName("thousand_sep")]
    public string ThousandSep { get; set; }

    [JsonPropertyName("timestamp_fmt")]
    public string TimestampFmt { get; set; }

    [JsonPropertyName("date_fmt")]
    public string DateFmt { get; set; }

    [JsonPropertyName("decimal_sep")]
    public string DecimalSep { get; set; }
}