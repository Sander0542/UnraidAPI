using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class ContainerPort
    {
        [JsonPropertyName("ip")]
        public string Ip { get; set; }

        [JsonPropertyName("privatePort")]
        public int? PrivatePort { get; set; }

        [JsonPropertyName("publicPort")]
        public int? PublicPort { get; set; }

        [JsonPropertyName("type")]
        public ContainerPortType? Type { get; set; }
    }
}