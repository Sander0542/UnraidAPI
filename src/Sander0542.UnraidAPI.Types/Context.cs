using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Context
    {
        [JsonPropertyName("query")]
        public dynamic Query { get; set; }

        [JsonPropertyName("params")]
        public dynamic Params { get; set; }

        [JsonPropertyName("data")]
        public dynamic Data { get; set; }

        [JsonPropertyName("user")]
        public dynamic User { get; set; }
    }
}