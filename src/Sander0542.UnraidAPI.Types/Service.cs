using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Service
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("online")]
        public bool? Online { get; set; }

        [JsonPropertyName("uptime")]
        public int? Uptime { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}