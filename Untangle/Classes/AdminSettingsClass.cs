//Non-nullable field is uninitialized
#pragma warning disable CS8618
// Non-accessed field
#pragma warning disable CS0414
// Unassigned field
#pragma warning disable CS0649

// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnassignedField.Global

using Serilog;
using static Untangle.Classes.Base;

namespace Untangle.Classes;

public class AdminSettingsClass
{
    public class AdminSettingsResponse
    {
        public AdminSettings Result;
        public uint Id;
    }

    public class AdminSettings
    {
        private const string ClassName = "AdminSettings";
        
        public string JavaClass;
        public string DefaultUsername;
        public uint Version;
        public Users Users;
        
        /// <summary>
        /// Applies local changes to remote
        /// </summary>
        public async Task ApplyAsync()
        {
            await UntangleApi.ApplyAsync(
                this,
                UntangleApi.Untangle!.WebUi!.AdminManager.ObjectId,
                "Settings",
                GetType().Name);
        }
    }

    public class Users
    {
        public string JavaClass;
        public List<UserSettings> List;
    }

    public class UserSettings
    {
        public string EmailAddress;
        public string Password;
        public bool EmailAlerts;
        public string JavaClass;
        public string PasswordHashShadow;
        public bool EmailSummaries;
        public string Descriptions;
        public string PasswordHashBase64;
        public string Username;
    }
}