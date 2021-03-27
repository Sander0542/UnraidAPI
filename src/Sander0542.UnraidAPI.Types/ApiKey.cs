using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class ApiKey
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("scopes")]
        public dynamic Scopes { get; set; }

        [JsonPropertyName("expiresAt")]
        public long ExpiresAt { get; set; }
    }
}
