using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Scope
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}