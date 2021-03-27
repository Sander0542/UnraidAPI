using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Server
    {
        [JsonPropertyName("owner")]
        public Owner Owner { get; set; }

        [JsonPropertyName("guid")]
        public string Guid { get; set; }

        [JsonPropertyName("apikey")]
        public string Apikey { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("status")]
        public Status? Status { get; set; }

        [JsonPropertyName("wanip")]
        public string Wanip { get; set; }

        [JsonPropertyName("lanip")]
        public string Lanip { get; set; }

        [JsonPropertyName("localurl")]
        public string Localurl { get; set; }

        [JsonPropertyName("remoteurl")]
        public string Remoteurl { get; set; }
    }
}