using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Case
    {
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("error")]
        public string Error { get; set; }

        [JsonPropertyName("base64")]
        public string Base64 { get; set; }
    }
}