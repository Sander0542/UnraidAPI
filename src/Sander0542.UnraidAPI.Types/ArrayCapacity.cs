using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class ArrayCapacity
    {
        [JsonPropertyName("bytes")]
        public Capacity Bytes { get; set; }

        [JsonPropertyName("disks")]
        public Capacity Disks { get; set; }
    }
}
