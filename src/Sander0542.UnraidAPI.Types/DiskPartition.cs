using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class DiskPartition
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("fsType")]
        public DiskFsType FsType { get; set; }

        [JsonPropertyName("size")]
        public long Size { get; set; }
    }
}