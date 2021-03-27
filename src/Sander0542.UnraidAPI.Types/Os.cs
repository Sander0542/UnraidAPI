using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Os
    {
        [JsonPropertyName("platform")]
        public string Platform { get; set; }

        [JsonPropertyName("distro")]
        public string Distro { get; set; }

        [JsonPropertyName("release")]
        public string Release { get; set; }

        [JsonPropertyName("codename")]
        public string Codename { get; set; }

        [JsonPropertyName("kernel")]
        public string Kernel { get; set; }

        [JsonPropertyName("arch")]
        public string Arch { get; set; }

        [JsonPropertyName("hostname")]
        public string Hostname { get; set; }

        [JsonPropertyName("codepage")]
        public string Codepage { get; set; }

        [JsonPropertyName("logofile")]
        public string Logofile { get; set; }

        [JsonPropertyName("serial")]
        public string Serial { get; set; }

        [JsonPropertyName("build")]
        public string Build { get; set; }
    }
}