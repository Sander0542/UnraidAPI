using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Mount
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("directory")]
        public string Directory { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("permissions")]
        public string Permissions { get; set; }
    }
}