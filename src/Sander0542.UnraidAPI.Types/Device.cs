using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Device
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        [JsonPropertyName("device")]
        public string Name { get; set; }

        [JsonPropertyName("sectors")]
        public string Sectors { get; set; }

        [JsonPropertyName("sectorSize")]
        public string SectorSize { get; set; }
    }
}