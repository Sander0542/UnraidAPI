using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Versions
    {
        [JsonPropertyName("kernel")]
        public string Kernel { get; set; }

        [JsonPropertyName("openssl")]
        public string Openssl { get; set; }

        [JsonPropertyName("systemOpenssl")]
        public string SystemOpenssl { get; set; }

        [JsonPropertyName("systemOpensslLib")]
        public string SystemOpensslLib { get; set; }

        [JsonPropertyName("node")]
        public string Node { get; set; }

        [JsonPropertyName("v8")]
        public string V8 { get; set; }

        [JsonPropertyName("npm")]
        public string Npm { get; set; }

        [JsonPropertyName("yarn")]
        public string Yarn { get; set; }

        [JsonPropertyName("pm2")]
        public string Pm2 { get; set; }

        [JsonPropertyName("gulp")]
        public string Gulp { get; set; }

        [JsonPropertyName("grunt")]
        public string Grunt { get; set; }

        [JsonPropertyName("git")]
        public string Git { get; set; }

        [JsonPropertyName("tsc")]
        public string Tsc { get; set; }

        [JsonPropertyName("mysql")]
        public string Mysql { get; set; }

        [JsonPropertyName("redis")]
        public string Redis { get; set; }

        [JsonPropertyName("mongodb")]
        public string Mongodb { get; set; }

        [JsonPropertyName("apache")]
        public string Apache { get; set; }

        [JsonPropertyName("nginx")]
        public string Nginx { get; set; }

        [JsonPropertyName("php")]
        public string Php { get; set; }

        [JsonPropertyName("docker")]
        public string Docker { get; set; }

        [JsonPropertyName("postfix")]
        public string Postfix { get; set; }

        [JsonPropertyName("postgresql")]
        public string Postgresql { get; set; }

        [JsonPropertyName("perl")]
        public string Perl { get; set; }

        [JsonPropertyName("python")]
        public string Python { get; set; }

        [JsonPropertyName("gcc")]
        public string Gcc { get; set; }

        [JsonPropertyName("unraid")]
        public string Unraid { get; set; }
    }
}