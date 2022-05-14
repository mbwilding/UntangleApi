using System.Text.Json.Serialization;

namespace Untangle.Uvm;

public class SkinInfo
{
    [JsonPropertyName("adminSkin")]
    public bool AdminSkin { get; set; }

    [JsonPropertyName("adminSkinOutOfDate")]
    public bool AdminSkinOutOfDate { get; set; }

    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    [JsonPropertyName("extjsTheme")]
    public string ExtjsTheme { get; set; }

    [JsonPropertyName("adminSkinVersion")]
    public int AdminSkinVersion { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("appsViewType")]
    public string AppsViewType { get; set; }
}