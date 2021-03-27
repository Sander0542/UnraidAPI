using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class SecurityLabel
    {
        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("enforcing")]
        public bool? Enforcing { get; set; }
    }
}