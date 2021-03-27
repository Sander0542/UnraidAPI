using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class InfoApps
    {
        [JsonPropertyName("installed")]
        public int? Installed { get; set; }

        [JsonPropertyName("started")]
        public int? Started { get; set; }
    }
}