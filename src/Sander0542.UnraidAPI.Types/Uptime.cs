using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Uptime
    {
        [JsonPropertyName("milliseconds")]
        public int Milliseconds { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }
    }
}