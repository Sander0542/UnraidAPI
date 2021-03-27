using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Owner
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    }
}