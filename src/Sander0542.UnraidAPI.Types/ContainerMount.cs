using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class ContainerMount
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("destination")]
        public string Destination { get; set; }

        [JsonPropertyName("driver")]
        public string Driver { get; set; }

        [JsonPropertyName("mode")]
        public string Mode { get; set; }

        [JsonPropertyName("rw")]
        public bool Rw { get; set; }

        [JsonPropertyName("propagation")]
        public string Propagation { get; set; }
    }
}