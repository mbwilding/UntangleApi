using System.Text.Json.Serialization;
using Untangle.Uvm;

namespace Untangle.Classes;

public class Setup
{
    [JsonPropertyName("adminManager")]
    public AdminManager? AdminManager { get; set; }

    [JsonPropertyName("networkManager")]
    public NetworkManager? NetworkManager { get; set; }

    [JsonPropertyName("systemManager")]
    public SystemManager? SystemManager { get; set; }

    [JsonPropertyName("connectivityTester")]
    public ConnectivityTester? ConnectivityTester { get; set; }

    [JsonPropertyName("mailSender")]
    public MailSender? MailSender { get; set; }
}