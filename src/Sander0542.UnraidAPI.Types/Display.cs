using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Display
    {
        [JsonPropertyName("case")]
        public Case Case { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("scale")]
        public bool? Scale { get; set; }

        [JsonPropertyName("tabs")]
        public bool? Tabs { get; set; }

        [JsonPropertyName("users")]
        public string Users { get; set; }

        [JsonPropertyName("resize")]
        public bool? Resize { get; set; }

        [JsonPropertyName("wwn")]
        public bool? Wwn { get; set; }

        [JsonPropertyName("total")]
        public bool? Total { get; set; }

        [JsonPropertyName("usage")]
        public bool? Usage { get; set; }

        [JsonPropertyName("banner")]
        public string Banner { get; set; }

        [JsonPropertyName("dashapps")]
        public string Dashapps { get; set; }

        [JsonPropertyName("theme")]
        public Theme? Theme { get; set; }

        [JsonPropertyName("text")]
        public bool? Text { get; set; }

        [JsonPropertyName("unit")]
        public Temperature? Unit { get; set; }

        [JsonPropertyName("warning")]
        public int? Warning { get; set; }

        [JsonPropertyName("critical")]
        public int? Critical { get; set; }

        [JsonPropertyName("hot")]
        public int? Hot { get; set; }

        [JsonPropertyName("max")]
        public int? Max { get; set; }
    }
}