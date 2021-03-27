using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Welcome
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}