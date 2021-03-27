using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Gpu
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("typeid")]
        public string Typeid { get; set; }

        [JsonPropertyName("vendorname")]
        public string Vendorname { get; set; }

        [JsonPropertyName("productid")]
        public string Productid { get; set; }

        [JsonPropertyName("blacklisted")]
        public bool Blacklisted { get; set; }

        [JsonPropertyName("class")]
        public string Class { get; set; }
    }
}