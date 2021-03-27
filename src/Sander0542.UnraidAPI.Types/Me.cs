using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Me : IUserAccount
    {
        [JsonPropertyName("permissions")]
        public dynamic Permissions { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("role")]
        public string Role { get; set; }
    }
}