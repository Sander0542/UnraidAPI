using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Devices
    {
        [JsonPropertyName("gpu")]
        public List<Gpu> Gpu { get; set; }

        [JsonPropertyName("network")]
        public List<Network> Network { get; set; }

        [JsonPropertyName("pci")]
        public List<Pci> Pci { get; set; }

        [JsonPropertyName("usb")]
        public List<Usb> Usb { get; set; }
    }
}