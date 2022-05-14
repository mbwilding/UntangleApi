using System.Text.Json.Serialization;
using Untangle.Uvm.App;
using Untangle.Uvm.Network;

namespace Untangle.Uvm;

public class List
{
    [JsonPropertyName("policyId")]
    public int? PolicyId { get; set; }

    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("appName")]
    public string AppName { get; set; }

    [JsonPropertyName("targetState")]
    public string TargetState { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }

    [JsonPropertyName("autoLoad")]
    public bool AutoLoad { get; set; }

    [JsonPropertyName("invisible")]
    public bool Invisible { get; set; }

    [JsonPropertyName("minimumMemory")]
    public int? MinimumMemory { get; set; }

    [JsonPropertyName("className")]
    public string ClassName { get; set; }

    [JsonPropertyName("viewPosition")]
    public int ViewPosition { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("hasPowerButton")]
    public bool HasPowerButton { get; set; }

    [JsonPropertyName("autoInstall")]
    public bool AutoInstall { get; set; }

    [JsonPropertyName("autoStart")]
    public bool AutoStart { get; set; }

    [JsonPropertyName("daemon")]
    public string Daemon { get; set; }

    [JsonPropertyName("appBase")]
    public string AppBase { get; set; }

    [JsonPropertyName("supportedArchitectures")]
    public SupportedArchitectures SupportedArchitectures { get; set; }

    [JsonPropertyName("autoInstallMinMemory")]
    public int AutoInstallMinMemory { get; set; }

    [JsonPropertyName("autoInstallMinRequireInterfaces")]
    public int AutoInstallMinRequireInterfaces { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("parents")]
    public Parents Parents { get; set; }

    [JsonPropertyName("bypass")]
    public bool Bypass { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("conditions")]
    public FilterRuleConditions Conditions { get; set; }

    [JsonPropertyName("ruleId")]
    public int RuleId { get; set; }

    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    [JsonPropertyName("invert")]
    public bool Invert { get; set; }

    [JsonPropertyName("conditionType")]
    public string ConditionType { get; set; }

    [JsonPropertyName("value")]
    public string Value { get; set; }

    [JsonPropertyName("v6StaticDns2")]
    public object V6StaticDns2 { get; set; }

    [JsonPropertyName("raEnabled")]
    public object RaEnabled { get; set; }

    [JsonPropertyName("v6StaticDns1")]
    public object V6StaticDns1 { get; set; }

    [JsonPropertyName("v4ConfigType")]
    public string V4ConfigType { get; set; }

    [JsonPropertyName("vrrpEnabled")]
    public object VrrpEnabled { get; set; }

    [JsonPropertyName("wirelessChannel")]
    public object WirelessChannel { get; set; }

    [JsonPropertyName("wirelessVisibility")]
    public int WirelessVisibility { get; set; }

    [JsonPropertyName("dhcpOptions")]
    public object DhcpOptions { get; set; }

    [JsonPropertyName("v4StaticNetmask")]
    public object V4StaticNetmask { get; set; }

    [JsonPropertyName("configType")]
    public string ConfigType { get; set; }

    [JsonPropertyName("wirelessSsid")]
    public object WirelessSsid { get; set; }

    [JsonPropertyName("isWirelessInterface")]
    public bool IsWirelessInterface { get; set; }

    [JsonPropertyName("v6Aliases")]
    public V6Aliases V6Aliases { get; set; }

    [JsonPropertyName("dhcpLeaseDuration")]
    public object DhcpLeaseDuration { get; set; }

    [JsonPropertyName("v4AutoDns2Override")]
    public object V4AutoDns2Override { get; set; }

    [JsonPropertyName("dhcpNetmaskOverride")]
    public object DhcpNetmaskOverride { get; set; }

    [JsonPropertyName("dhcpPrefixOverride")]
    public object DhcpPrefixOverride { get; set; }

    [JsonPropertyName("isWan")]
    public bool IsWan { get; set; }

    [JsonPropertyName("v4StaticGateway")]
    public object V4StaticGateway { get; set; }

    [JsonPropertyName("systemDev")]
    public object SystemDev { get; set; }

    [JsonPropertyName("v4NatEgressTraffic")]
    public object V4NatEgressTraffic { get; set; }

    [JsonPropertyName("bridgedTo")]
    public object BridgedTo { get; set; }

    [JsonPropertyName("downloadBandwidthKbps")]
    public object DownloadBandwidthKbps { get; set; }

    [JsonPropertyName("v6StaticPrefixLength")]
    public object V6StaticPrefixLength { get; set; }

    [JsonPropertyName("v4AutoPrefixOverride")]
    public object V4AutoPrefixOverride { get; set; }

    [JsonPropertyName("wirelessEncryption")]
    public object WirelessEncryption { get; set; }

    [JsonPropertyName("isVirtualInterface")]
    public bool IsVirtualInterface { get; set; }

    [JsonPropertyName("v4PPPoEUsePeerDns")]
    public object V4PPPoEUsePeerDns { get; set; }

    [JsonPropertyName("v6StaticGateway")]
    public object V6StaticGateway { get; set; }

    [JsonPropertyName("uploadBandwidthKbps")]
    public object UploadBandwidthKbps { get; set; }

    [JsonPropertyName("v6ConfigType")]
    public string V6ConfigType { get; set; }

    [JsonPropertyName("isVlanInterface")]
    public bool IsVlanInterface { get; set; }

    [JsonPropertyName("v4AutoAddressOverride")]
    public object V4AutoAddressOverride { get; set; }

    [JsonPropertyName("wirelessMode")]
    public string WirelessMode { get; set; }

    [JsonPropertyName("vlanTag")]
    public object VlanTag { get; set; }

    [JsonPropertyName("hidden")]
    public object Hidden { get; set; }

    [JsonPropertyName("v4StaticAddress")]
    public object V4StaticAddress { get; set; }

    [JsonPropertyName("v4PPPoEPassword")]
    public object V4PPPoEPassword { get; set; }

    [JsonPropertyName("v6StaticAddress")]
    public object V6StaticAddress { get; set; }

    [JsonPropertyName("v4PPPoEDns2")]
    public object V4PPPoEDns2 { get; set; }

    [JsonPropertyName("v4PPPoEDns1")]
    public object V4PPPoEDns1 { get; set; }

    [JsonPropertyName("dhcpDnsOverride")]
    public object DhcpDnsOverride { get; set; }

    [JsonPropertyName("supportedConfigTypes")]
    public object SupportedConfigTypes { get; set; }

    [JsonPropertyName("v4PPPoEUsername")]
    public object V4PPPoEUsername { get; set; }

    [JsonPropertyName("wirelessPassword")]
    public object WirelessPassword { get; set; }

    [JsonPropertyName("v4NatIngressTraffic")]
    public object V4NatIngressTraffic { get; set; }

    [JsonPropertyName("v4StaticDns2")]
    public object V4StaticDns2 { get; set; }

    [JsonPropertyName("v4StaticDns1")]
    public object V4StaticDns1 { get; set; }

    [JsonPropertyName("v4AutoDns1Override")]
    public object V4AutoDns1Override { get; set; }

    [JsonPropertyName("symbolicDev")]
    public object SymbolicDev { get; set; }

    [JsonPropertyName("v4Aliases")]
    public V4Aliases V4Aliases { get; set; }

    [JsonPropertyName("dhcpRangeStart")]
    public object DhcpRangeStart { get; set; }

    [JsonPropertyName("vrrpId")]
    public object VrrpId { get; set; }

    [JsonPropertyName("vlanParent")]
    public object VlanParent { get; set; }

    [JsonPropertyName("dhcpGatewayOverride")]
    public object DhcpGatewayOverride { get; set; }

    [JsonPropertyName("imqDev")]
    public object ImqDev { get; set; }

    [JsonPropertyName("v4AutoGatewayOverride")]
    public object V4AutoGatewayOverride { get; set; }

    [JsonPropertyName("physicalDev")]
    public object PhysicalDev { get; set; }

    [JsonPropertyName("v4PPPoERootDev")]
    public object V4PPPoERootDev { get; set; }

    [JsonPropertyName("vrrpAliases")]
    public VrrpAliases VrrpAliases { get; set; }

    [JsonPropertyName("interfaceId")]
    public int InterfaceId { get; set; }

    [JsonPropertyName("v4StaticPrefix")]
    public object V4StaticPrefix { get; set; }

    [JsonPropertyName("dhcpEnabled")]
    public object DhcpEnabled { get; set; }

    [JsonPropertyName("v4AutoNetmaskOverride")]
    public object V4AutoNetmaskOverride { get; set; }

    [JsonPropertyName("dhcpRangeEnd")]
    public object DhcpRangeEnd { get; set; }

    [JsonPropertyName("vrrpPriority")]
    public object VrrpPriority { get; set; }

    [JsonPropertyName("address")]
    public string Address { get; set; }

    [JsonPropertyName("newPort")]
    public int NewPort { get; set; }

    [JsonPropertyName("simple")]
    public bool Simple { get; set; }

    [JsonPropertyName("newDestination")]
    public string NewDestination { get; set; }

    [JsonPropertyName("area")]
    public string Area { get; set; }

    [JsonPropertyName("virtualLinks")]
    public VirtualLinks VirtualLinks { get; set; }

    [JsonPropertyName("authentication")]
    public int Authentication { get; set; }

    [JsonPropertyName("duplex")]
    public string Duplex { get; set; }

    [JsonPropertyName("deviceName")]
    public string DeviceName { get; set; }

    [JsonPropertyName("mtu")]
    public object Mtu { get; set; }

    [JsonPropertyName("counterValue")]
    public object CounterValue { get; set; }

    [JsonPropertyName("expert")]
    public bool Expert { get; set; }

    [JsonPropertyName("displayUnits")]
    public object DisplayUnits { get; set; }

    [JsonPropertyName("timeValue")]
    public object TimeValue { get; set; }

    [JsonPropertyName("blocked")]
    public bool Blocked { get; set; }

    [JsonPropertyName("readOnly")]
    public bool ReadOnly { get; set; }

    [JsonPropertyName("ipv6Enabled")]
    public bool Ipv6Enabled { get; set; }

    [JsonPropertyName("macAddress")]
    public string MacAddress { get; set; }

    [JsonPropertyName("allow")]
    public bool Allow { get; set; }

    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    [JsonPropertyName("priorityName")]
    public string PriorityName { get; set; }

    [JsonPropertyName("downloadReservation")]
    public int DownloadReservation { get; set; }

    [JsonPropertyName("uploadLimit")]
    public int UploadLimit { get; set; }

    [JsonPropertyName("downloadLimit")]
    public int DownloadLimit { get; set; }

    [JsonPropertyName("uploadReservation")]
    public int UploadReservation { get; set; }

    [JsonPropertyName("priorityId")]
    public int PriorityId { get; set; }
}