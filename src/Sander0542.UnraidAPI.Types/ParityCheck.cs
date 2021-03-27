using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class ParityCheck
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        [JsonPropertyName("speed")]
        public string Speed { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("errors")]
        public string Errors { get; set; }
    }
}