using System.Text.Json.Serialization;

namespace Untangle.Classes;

public class AdminSettingsClass
{
    public class AdminSettingsResponse
    {
        [JsonPropertyName("result")]
        public AdminSettings Result { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }
    }

    public class AdminSettings
    {
        [JsonPropertyName("javaClass")]
        public string JavaClass { get; set; }

        [JsonPropertyName("defaultUsername")]
        public string DefaultUsername { get; set; }

        [JsonPropertyName("version")]
        public int Version { get; set; }

        [JsonPropertyName("users")]
        public Users Users { get; set; }
        
        /// <summary>
        /// Applies local changes to remote
        /// </summary>
        public async Task ApplyAsync()
        {
            // TODO
            await UntangleApi.ApplyAsync(
                this,
                UntangleApi.Untangle!.Uvm.AdminManager!.ObjectId,
                GetType().Name);
        }
    }

    public class Users
    {
        [JsonPropertyName("javaClass")]
        public string JavaClass { get; set; }

        [JsonPropertyName("list")]
        public List<UserSettings> List { get; set; }
    }

    public class UserSettings
    {
        [JsonPropertyName("emailAddress")]
        public string? EmailAddress { get; set; }

        [JsonPropertyName("password")]
        public string? Password { get; set; }

        [JsonPropertyName("emailAlerts")]
        public bool? EmailAlerts { get; set; }

        [JsonPropertyName("javaClass")]
        public string? JavaClass { get; set; }

        [JsonPropertyName("passwordHashShadow")]
        public string? PasswordHashShadow { get; set; }

        [JsonPropertyName("emailSummaries")]
        public bool? EmailSummaries { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("passwordHashBase64")]
        public string? PasswordHashBase64 { get; set; }

        [JsonPropertyName("username")]
        public string? Username { get; set; }
    }
}