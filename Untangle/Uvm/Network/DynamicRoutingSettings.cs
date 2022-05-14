using System.Text.Json.Serialization;

namespace Untangle.Uvm.Network;

public class DynamicRoutingSettings
{
    [JsonPropertyName("javaClass")]
    public string JavaClass { get; set; }

    [JsonPropertyName("ospfDefaultInformationOriginateMetric")]
    public int OspfDefaultInformationOriginateMetric { get; set; }

    [JsonPropertyName("bgpNeighbors")]
    public BgpNeighbors BgpNeighbors { get; set; }

    [JsonPropertyName("bgpEnabled")]
    public bool BgpEnabled { get; set; }

    [JsonPropertyName("ospfUseDefaultMetricEnabled")]
    public bool OspfUseDefaultMetricEnabled { get; set; }

    [JsonPropertyName("ospfRedistStaticMetric")]
    public int OspfRedistStaticMetric { get; set; }

    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }

    [JsonPropertyName("ospfEnabled")]
    public bool OspfEnabled { get; set; }

    [JsonPropertyName("ospfRedistStaticEnabled")]
    public bool OspfRedistStaticEnabled { get; set; }

    [JsonPropertyName("ospfDefaultInformationOriginateExternalType")]
    public int OspfDefaultInformationOriginateExternalType { get; set; }

    [JsonPropertyName("ospfRedistConnectedMetric")]
    public int OspfRedistConnectedMetric { get; set; }

    [JsonPropertyName("bgpRouterId")]
    public string BgpRouterId { get; set; }

    [JsonPropertyName("ospfRedistBgpMetric")]
    public int OspfRedistBgpMetric { get; set; }

    [JsonPropertyName("bgpNetworks")]
    public BgpNetworks BgpNetworks { get; set; }

    [JsonPropertyName("ospfRedistConnectedExternalType")]
    public int OspfRedistConnectedExternalType { get; set; }

    [JsonPropertyName("ospfAreas")]
    public OspfAreas OspfAreas { get; set; }

    [JsonPropertyName("ospfRouterId")]
    public string OspfRouterId { get; set; }

    [JsonPropertyName("ospfAutoCost")]
    public int OspfAutoCost { get; set; }

    [JsonPropertyName("ospfRedistBgpExternalType")]
    public int OspfRedistBgpExternalType { get; set; }

    [JsonPropertyName("bgpRouterAs")]
    public string BgpRouterAs { get; set; }

    [JsonPropertyName("ospfDefaultInformationOriginateType")]
    public int OspfDefaultInformationOriginateType { get; set; }

    [JsonPropertyName("ospfDefaultMetric")]
    public int OspfDefaultMetric { get; set; }

    [JsonPropertyName("ospfNetworks")]
    public OspfNetworks OspfNetworks { get; set; }

    [JsonPropertyName("ospfRedistConnectedEnabled")]
    public bool OspfRedistConnectedEnabled { get; set; }

    [JsonPropertyName("ospfRedistBgpEnabled")]
    public bool OspfRedistBgpEnabled { get; set; }

    [JsonPropertyName("ospfInterfaces")]
    public OspfInterfaces OspfInterfaces { get; set; }

    [JsonPropertyName("ospfRedistStaticExternalType")]
    public int OspfRedistStaticExternalType { get; set; }

    [JsonPropertyName("ospfAbrType")]
    public int OspfAbrType { get; set; }
}