using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Baseboard
    {
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("serial")]
        public string Serial { get; set; }

        [JsonPropertyName("assetTag")]
        public string AssetTag { get; set; }
    }
}