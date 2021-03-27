using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class VmNetwork
    {
        [JsonPropertyName("_placeholderType")]
        public string PlaceholderType { get; set; }
    }
}