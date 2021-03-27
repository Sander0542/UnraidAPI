using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class ContainerHostConfig
    {
        [JsonPropertyName("networkMode")]
        public string NetworkMode { get; set; }
    }
}