using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class QosSettings
{
    [JsonPropertyName("queueDiscipline")]
    public string QueueDiscipline { get; set; }

    [JsonPropertyName("qosRules")]
    public QosRules QosRules { get; set; }

    [JsonPropertyName("defaultPriority")]
    public int DefaultPriority { get; set; }

    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("openvpnPriority")]
    public int OpenvpnPriority { get; set; }

    [JsonPropertyName("sshPriority")]
    public int SshPriority { get; set; }

    [JsonPropertyName("dnsPriority")]
    public int DnsPriority { get; set; }

    [JsonPropertyName("pingPriority")]
    public int PingPriority { get; set; }

    [JsonPropertyName("qosEnabled")]
    public bool QosEnabled { get; set; }

    [JsonPropertyName("qosPriorities")]
    public QosPriorities QosPriorities { get; set; }
}