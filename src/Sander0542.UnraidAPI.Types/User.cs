using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class User : IUserAccount
    {
        [JsonPropertyName("password")]
        public bool? Password { get; set; }

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