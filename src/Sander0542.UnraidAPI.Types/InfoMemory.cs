using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class InfoMemory
    {
        [JsonPropertyName("max")]
        public long Max { get; set; }

        [JsonPropertyName("total")]
        public long Total { get; set; }

        [JsonPropertyName("free")]
        public long Free { get; set; }

        [JsonPropertyName("used")]
        public long Used { get; set; }

        [JsonPropertyName("active")]
        public long Active { get; set; }

        [JsonPropertyName("available")]
        public long Available { get; set; }

        [JsonPropertyName("buffcache")]
        public long Buffcache { get; set; }

        [JsonPropertyName("swaptotal")]
        public long Swaptotal { get; set; }

        [JsonPropertyName("swapused")]
        public long Swapused { get; set; }

        [JsonPropertyName("swapfree")]
        public long Swapfree { get; set; }

        [JsonPropertyName("layout")]
        public List<MemoryLayout> Layout { get; set; }
    }
}