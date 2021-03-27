using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Network
    {
        [JsonPropertyName("iface")]
        public string Iface { get; set; }

        [JsonPropertyName("ifaceName")]
        public string IfaceName { get; set; }

        [JsonPropertyName("ipv4")]
        public string Ipv4 { get; set; }

        [JsonPropertyName("ipv6")]
        public string Ipv6 { get; set; }

        [JsonPropertyName("mac")]
        public string Mac { get; set; }

        [JsonPropertyName("internal")]
        public string Internal { get; set; }

        [JsonPropertyName("operstate")]
        public string Operstate { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("duplex")]
        public string Duplex { get; set; }

        [JsonPropertyName("mtu")]
        public string Mtu { get; set; }

        [JsonPropertyName("speed")]
        public string Speed { get; set; }

        [JsonPropertyName("carrierChanges")]
        public string CarrierChanges { get; set; }
    }
}