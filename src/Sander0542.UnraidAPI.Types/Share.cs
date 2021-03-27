using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Share
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("free")]
        public int? Free { get; set; }

        [JsonPropertyName("size")]
        public int? Size { get; set; }

        [JsonPropertyName("include")]
        public List<string> Include { get; set; }

        [JsonPropertyName("exclude")]
        public List<string> Exclude { get; set; }

        [JsonPropertyName("cache")]
        public bool? Cache { get; set; }

        [JsonPropertyName("nameOrig")]
        public string NameOrig { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("allocator")]
        public string Allocator { get; set; }

        [JsonPropertyName("splitLevel")]
        public string SplitLevel { get; set; }

        [JsonPropertyName("floor")]
        public string Floor { get; set; }

        [JsonPropertyName("cow")]
        public string Cow { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("luksStatus")]
        public string LuksStatus { get; set; }
    }
}