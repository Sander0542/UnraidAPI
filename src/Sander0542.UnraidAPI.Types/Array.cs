using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Array
    {
        [JsonPropertyName("previousState")]
        public ArrayState? PreviousState { get; set; }

        [JsonPropertyName("pendingState")]
        public ArrayPendingState? PendingState { get; set; }

        [JsonPropertyName("state")]
        public ArrayState State { get; set; }

        [JsonPropertyName("capacity")]
        public ArrayCapacity Capacity { get; set; }

        [JsonPropertyName("boot")]
        public ArrayDataDisk Boot { get; set; }

        [JsonPropertyName("parities")]
        public List<ArrayDataDisk> Parities { get; set; }

        [JsonPropertyName("disks")]
        public List<ArrayDataDisk> Disks { get; set; }

        [JsonPropertyName("caches")]
        public List<ArrayDataDisk> Caches { get; set; }
    }
}
