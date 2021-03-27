using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class DockerContainer
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("names")]
        public List<string> Names { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("imageId")]
        public string ImageId { get; set; }

        [JsonPropertyName("command")]
        public string Command { get; set; }

        [JsonPropertyName("created")]
        public int Created { get; set; }

        [JsonPropertyName("ports")]
        public List<ContainerPort> Ports { get; set; }

        [JsonPropertyName("sizeRootFs")]
        public int SizeRootFs { get; set; }

        [JsonPropertyName("labels")]
        public dynamic Labels { get; set; }

        [JsonPropertyName("state")]
        public ContainerState? State { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("hostConfig")]
        public ContainerHostConfig HostConfig { get; set; }

        [JsonPropertyName("networkSettings")]
        public dynamic NetworkSettings { get; set; }

        [JsonPropertyName("mounts")]
        public List<dynamic> Mounts { get; set; }

        [JsonPropertyName("autoStart")]
        public bool AutoStart { get; set; }
    }
}