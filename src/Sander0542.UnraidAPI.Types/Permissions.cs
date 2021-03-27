using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Permissions
    {
        [JsonPropertyName("scopes")]
        public dynamic Scopes { get; set; }

        [JsonPropertyName("grants")]
        public dynamic Grants { get; set; }
    }
}