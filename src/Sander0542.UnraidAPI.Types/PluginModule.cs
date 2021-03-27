using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class PluginModule
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("filePath")]
        public string FilePath { get; set; }

        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; }
    }
}