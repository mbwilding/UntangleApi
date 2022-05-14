using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class InterfaceSettings
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("interfaceId")]
    public int? InterfaceId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("physicalDev")]
    public string? PhysicalDev { get; set; }
    
    [JsonPropertyName("systemDev")]
    public string? SystemDev { get; set; }
    
    [JsonPropertyName("imqDev")]
    public string? ImqDev { get; set; }
    
    [JsonPropertyName("hidden")]
    public bool? Hidden { get; set; }
    
    [JsonPropertyName("isWan")]
    public bool? IsWan { get; set; }
    
    [JsonPropertyName("isVlanInterface")]
    public bool? IsVlanInterface { get; set; }
    
    [JsonPropertyName("isVirtualInterface")]
    public bool? IsVirtualInterface { get; set; }
    
    [JsonPropertyName("isWirelessInterface")]
    public bool? IsWirelessInterface { get; set; }
    
    [JsonPropertyName("vlanTag")]
    public int? VlanTag { get; set; }
    
    [JsonPropertyName("vlanParent")]
    public int? VlanParent { get; set; }
    
    [JsonPropertyName("configType")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ConfigType? ConfigType { get; set; }
    
    [JsonPropertyName("supportedConfigTypes")]
    public ConfigType[]? SupportedConfigTypes { get; set; }
    
    [JsonPropertyName("bridgedTo")]
    public int? BridgedTo { get; set; }
    
    [JsonPropertyName("v4ConfigType")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public V4ConfigType? V4ConfigType { get; set; }
    
    [JsonPropertyName("v4StaticAddress")]
    public string? V4StaticAddress { get; set; }
    
    [JsonPropertyName("v4StaticPrefix")]
    public int? V4StaticPrefix { get; set; }
    
    [JsonPropertyName("v4StaticGateway")]
    public string? V4StaticGateway { get; set; }
    
    [JsonPropertyName("v4StaticDns1")]
    public string? V4StaticDns1 { get; set; }
    
    [JsonPropertyName("v4StaticDns2")]
    public string? V4StaticDns2 { get; set; }
    
    [JsonPropertyName("v4AutoAddressOverride")]
    public string? V4AutoAddressOverride { get; set; }
    
    [JsonPropertyName("v4AutoPrefixOverride")]
    public int? V4AutoPrefixOverride { get; set; }
    
    [JsonPropertyName("v4AutoDns1Override")]
    public string? V4AutoDns1Override { get; set; }
    
    [JsonPropertyName("v4AutoDns2Override")]
    public string? V4AutoDns2Override { get; set; }

    [JsonPropertyName("v4PPPoERootDev")]
    public string? V4PPPoERootDev { get; set; }
    
    [JsonPropertyName("v4PPPoEUsername")]
    public string? V4PPPoEUsername { get; set; }

    [JsonPropertyName("v4PPPoEPassword")]
    public string? V4PPPoEPassword { get; set; }

    [JsonPropertyName("v4PPPoEUsePeerDns")]
    public bool? V4PPPoEUsePeerDns { get; set; }
    
    [JsonPropertyName("v4PPPoEDns1")]
    public string? V4PPPoEDns1 { get; set; }
    
    [JsonPropertyName("v4PPPoEDns2")]
    public string? V4PPPoEDns2 { get; set; }
    
    [JsonPropertyName("v4NatEgressTraffic")]
    public bool? V4NatEgressTraffic { get; set; }

    [JsonPropertyName("v4NatIngressTraffic")]
    public bool? V4NatIngressTraffic { get; set; }


    
    // TODO FIRST
    
    /*
    public List<InterfaceAlias> getV4Aliases( ) { return this.v4Aliases; }
    public List<InterfaceAlias> getV6Aliases( ) { return this.v6Aliases; }
    public V6ConfigType getV6ConfigType( ) { return this.v6ConfigType; }
    public string? getV6StaticAddress( ) { return this.v6StaticAddress; }
    public int? getV6StaticPrefixLength( ) { return this.v6StaticPrefixLength; }
    public string? getV6StaticGateway( ) { return this.v6StaticGateway; }
    public string? getV6StaticDns1( ) { return this.v6StaticDns1; }
    public string? getV6StaticDns2( ) { return this.v6StaticDns2; }
    public bool? getDhcpEnabled() { return this.dhcpEnabled; }
    public string? getDhcpRangeStart() { return this.dhcpRangeStart; }
    public string? getDhcpRangeEnd() { return this.dhcpRangeEnd; }
    public int? getDhcpLeaseDuration() { return this.dhcpLeaseDuration; }
    public string? getDhcpGatewayOverride() { return this.dhcpGatewayOverride; }
    public int? getDhcpPrefixOverride() { return this.dhcpPrefixOverride; }
    public String getDhcpDnsOverride() { return this.dhcpDnsOverride; }
    public List<DhcpOption> getDhcpOptions() { return this.dhcpOptions; }
    public bool? getRaEnabled() { return this.raEnabled; }
    public int? getDownloadBandwidthKbps() { return this.downloadBandwidthKbps; }
    public int? getUploadBandwidthKbps() { return this.uploadBandwidthKbps; }
    public bool? getVrrpEnabled() { return this.vrrpEnabled; }
    public int? getVrrpId() { return this.vrrpId; }
    public int? getVrrpPriority() { return this.vrrpPriority; }
    public List<InterfaceAlias> getVrrpAliases( ) { return this.vrrpAliases; }
    public String getWirelessSsid( ) { return this.wirelessSsid; }
    public WirelessEncryption getWirelessEncryption( ) { return this.wirelessEncryption; }
    public WirelessMode getWirelessMode( ) { return this.wirelessMode; }
    public String getWirelessPassword( ) { return this.wirelessPassword; }
    public int? getWirelessChannel( ) { return this.wirelessChannel; }
    public int? getWirelessVisibility() { return this.wirelessVisibility; }
    */
    
}

public class InterfaceAlias
{
    
}

public enum ConfigType
{
    ADDRESSED,
    BRIDGED,
    DISABLED
}

public enum V4ConfigType
{
    STATIC,
    AUTO,
    PPPOE
}