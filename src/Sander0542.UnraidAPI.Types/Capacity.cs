using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Capacity
    {
        [JsonPropertyName("free")]
        public long Free { get; set; }

        [JsonPropertyName("used")]
        public long Used { get; set; }

        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}