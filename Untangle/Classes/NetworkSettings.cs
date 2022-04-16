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
    public BypassRules BypassRules;
    public bool LogLocalInboundSessions;
    public bool DynamicDnsServiceEnabled;
    public VirtualInterfaces VirtualInterfaces;
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

public class BypassRules
{
    public string JavaClass;
    public List<BypassRule> List;
}

public class BypassRule
{
    public bool Bypass;
    public string JavaClass;
    public string Description;
    public BypassRuleConditions Conditions;
    public uint RuleId;
    public bool Enabled;
}

public class BypassRuleConditions
{
    public string JavaClass;
    public List<BypassRuleCondition> List;
}

public class BypassRuleCondition
{
    public bool Invert;
    public string JavaClass;
    public string? ConditionType;
    public string Value;
}

public class VirtualInterfaces
{
    public string JavaClass;
    public List<VirtualInterface> List;
}

public class VirtualInterface
{
    // v6StaticDns2
    public bool? RaEnabled;
    // v6StaticDns1
    public string V4ConfigType;
    public bool? VrrpEnabled;
    // wirelessChannel
    public uint WirelessVisibility;
    // dhcpOptions
    // v4StaticNetmask
    public string ConfigType;
    public string? WirelessSsid;
    public bool IsWirelessInterface;
    // v6Aliases
    // dhcpLeaseDuration
    // v4AutoDns2Override
    // dhcpNetmaskOverride
    // dhcpPrefixOverride
    public bool IsWan;
    // v4StaticGateway
    // systemDev
    // v4NatEgressTraffic
    // bridgedTo
    // downloadBandwidthKbps
    // v6StaticPrefixLength
    // v4AutoPrefixOverride
    // wirelessEncryption
    public string Name;
    public bool IsVirtualInterface;
    // v4PPPoEUsePeerDns
    // v6StaticGateway
    // uploadBandwidthKbps
    public string V6ConfigType;
    public bool IsVlanInterface;
    // v4AutoAddressOverride
    public string WirelessMode;
    // vlanTag
    // hidden
    public string JavaClass;
    // v4StaticAddress
    // v4PPPoEPassword
    // v6StaticAddress
    // v4PPPoEDns2
    // v4PPPoEDns1
    // dhcpDnsOverride
    // supportedConfigTypes
    // v4PPPoEUsername
    // wirelessPassword
    // v4NatIngressTraffic
    // v4StaticDns2
    // v4StaticDns1
    // v4AutoDns1Override
    // symbolicDev
    // v4Aliases
    // dhcpRangeStart
    // vrrpId
    // vlanParent
    // dhcpGatewayOverride
    // imqDev
    // v4AutoGatewayOverride
    // physicalDev
    // v4PPPoERootDev
    // vrrpAliases
    public uint interfaceId;
    // v4StaticPrefix
    // dhcpEnabled
    // v4AutoNetmaskOverride
    // dhcpRangeEnd
    // vrrpPriority
}