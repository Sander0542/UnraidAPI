using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Usb
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}