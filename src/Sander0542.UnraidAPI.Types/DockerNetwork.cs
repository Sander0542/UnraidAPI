using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class DockerNetwork
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("created")]
        public string Created { get; set; }

        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        [JsonPropertyName("driver")]
        public string Driver { get; set; }

        [JsonPropertyName("enableIPv6")]
        public bool EnableIPv6 { get; set; }

        [JsonPropertyName("ipam")]
        public dynamic Ipam { get; set; }

        [JsonPropertyName("internal")]
        public bool Internal { get; set; }

        [JsonPropertyName("attachable")]
        public bool Attachable { get; set; }

        [JsonPropertyName("ingress")]
        public bool Ingress { get; set; }

        [JsonPropertyName("configFrom")]
        public dynamic ConfigFrom { get; set; }

        [JsonPropertyName("configOnly")]
        public bool ConfigOnly { get; set; }

        [JsonPropertyName("containers")]
        public dynamic Containers { get; set; }

        [JsonPropertyName("options")]
        public dynamic Options { get; set; }

        [JsonPropertyName("labels")]
        public dynamic Labels { get; set; }
    }
}