using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class NetworkSettings
{
    [JsonPropertyName("hostName")]
    public string HostName { get; set; }

    [JsonPropertyName("strictArpMode")]
    public bool StrictArpMode { get; set; }

    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("bypassRules")]
    public BypassRules BypassRules { get; set; }

    [JsonPropertyName("logLocalInboundSessions")]
    public bool LogLocalInboundSessions { get; set; }

    [JsonPropertyName("dynamicDnsServiceEnabled")]
    public bool DynamicDnsServiceEnabled { get; set; }

    [JsonPropertyName("virtualInterfaces")]
    public VirtualInterfaces VirtualInterfaces { get; set; }

    [JsonPropertyName("blockDuringRestarts")]
    public bool BlockDuringRestarts { get; set; }

    [JsonPropertyName("httpsPort")]
    public int HttpsPort { get; set; }

    [JsonPropertyName("dynamicDnsServiceHostnames")]
    public string DynamicDnsServiceHostnames { get; set; }

    [JsonPropertyName("dynamicDnsServicePassword")]
    public string DynamicDnsServicePassword { get; set; }

    [JsonPropertyName("logLocalOutboundSessions")]
    public bool LogLocalOutboundSessions { get; set; }

    [JsonPropertyName("dnsmasqOptions")]
    public object DnsmasqOptions { get; set; }

    [JsonPropertyName("dnsSettings")]
    public DnsSettings DnsSettings { get; set; }

    [JsonPropertyName("dhcpAuthoritative")]
    public bool DhcpAuthoritative { get; set; }

    [JsonPropertyName("blockReplayPackets")]
    public bool BlockReplayPackets { get; set; }

    [JsonPropertyName("sendIcmpRedirects")]
    public bool SendIcmpRedirects { get; set; }

    [JsonPropertyName("stpEnabled")]
    public bool StpEnabled { get; set; }

    [JsonPropertyName("portForwardRules")]
    public PortForwardRules PortForwardRules { get; set; }

    [JsonPropertyName("dynamicDnsServiceName")]
    public string DynamicDnsServiceName { get; set; }

    [JsonPropertyName("blockInvalidPackets")]
    public bool BlockInvalidPackets { get; set; }

    [JsonPropertyName("netflowSettings")]
    public NetflowSettings NetflowSettings { get; set; }

    [JsonPropertyName("filterRules")]
    public FilterRules FilterRules { get; set; }

    [JsonPropertyName("interfaces")]
    public Interfaces Interfaces { get; set; }

    [JsonPropertyName("dynamicRoutingSettings")]
    public DynamicRoutingSettings DynamicRoutingSettings { get; set; }

    [JsonPropertyName("publicUrlPort")]
    public int PublicUrlPort { get; set; }

    [JsonPropertyName("devices")]
    public Devices Devices { get; set; }

    [JsonPropertyName("httpPort")]
    public int HttpPort { get; set; }

    [JsonPropertyName("logBlockedSessions")]
    public bool LogBlockedSessions { get; set; }

    [JsonPropertyName("version")]
    public int Version { get; set; }

    [JsonPropertyName("enableSipNatHelper")]
    public bool EnableSipNatHelper { get; set; }

    [JsonPropertyName("publicUrlAddress")]
    public string PublicUrlAddress { get; set; }

    [JsonPropertyName("staticRoutes")]
    public StaticRoutes StaticRoutes { get; set; }

    [JsonPropertyName("accessRules")]
    public AccessRules AccessRules { get; set; }

    [JsonPropertyName("publicUrlMethod")]
    public string PublicUrlMethod { get; set; }

    [JsonPropertyName("staticDhcpEntries")]
    public StaticDhcpEntries StaticDhcpEntries { get; set; }

    [JsonPropertyName("domainName")]
    public string DomainName { get; set; }

    [JsonPropertyName("dynamicDnsServiceUsername")]
    public string DynamicDnsServiceUsername { get; set; }

    [JsonPropertyName("logBypassedSessions")]
    public bool LogBypassedSessions { get; set; }

    [JsonPropertyName("vlansEnabled")]
    public bool VlansEnabled { get; set; }

    [JsonPropertyName("lxcInterfaceId")]
    public int LxcInterfaceId { get; set; }

    [JsonPropertyName("upnpSettings")]
    public UpnpSettings UpnpSettings { get; set; }

    [JsonPropertyName("natRules")]
    public NatRules NatRules { get; set; }

    [JsonPropertyName("qosSettings")]
    public QosSettings QosSettings { get; set; }
}