//Non-nullable field is uninitialized
#pragma warning disable CS8618
// Non-accessed field
#pragma warning disable CS0414
// Unassigned field
#pragma warning disable CS0649

// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnassignedField.Global

namespace Untangle.Classes;

public class NetworkSettings
{
    public string HostName;
    public bool StrictArpMode;
    public string JavaClass;
    // TODO BypassRules
    public bool LogLocalInboundSessions;
    public bool DynamicDnsServiceEnabled;
    // TODO VirtualInterfaces
    public bool BlockDuringRestarts;
    public ushort HttpsPort;
    public string DynamicDnsServiceHostnames;
    public string DynamicDnsServicePassword;
    public bool LogLocalOutboundSessions;
    public object? DnsMasqOptions; // TODO JSON just had null
    // TODO DnsSettings
    public bool DhcpAuthoritative;
    public bool BlockReplayPackets;
    public bool SendIcmpRedirects;
    public bool StpEnabled;
    // TODO PortForwardRules
    public string DynamicDnsServiceName;
    public bool BlockInvalidPackets;
    // TODO NetflowSettings
    // TODO FilterRules
    // TODO Interfaces
    // TODO DynamicRoutingSettings
    public ushort PublicUrlPort;
    // TODO Devices
    public ushort HttpPort;
    public bool LogBlockedSessions;
    public uint Version;
    public bool EnableSipNatHelper;
    public string PublicUrlAddress;
    // TODO StaticRoutes
    // TODO AccessRules
    public string PublicUrlMethod;
    // TODO StaticDhcpEntries
    public string DomainName;
    public string DynamicDnsServiceUsername;
    public bool LogBypassedSessions;
    public bool VlansEnabled;
    public uint LxcInterfaceId;
    // TODO UpnpSettings
    // TODO NatRules
    // TODO QosSettings
}