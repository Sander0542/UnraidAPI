using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class MemoryLayout
    {
        [JsonPropertyName("size")]
        public long Size { get; set; }

        [JsonPropertyName("bank")]
        public string Bank { get; set; }

        [JsonPropertyName("type")]
        public MemoryType? Type { get; set; }

        [JsonPropertyName("clockSpeed")]
        public long ClockSpeed { get; set; }

        [JsonPropertyName("formFactor")]
        public MemoryFormFactor? FormFactor { get; set; }

        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonPropertyName("partNum")]
        public string PartNum { get; set; }

        [JsonPropertyName("serialNum")]
        public string SerialNum { get; set; }

        [JsonPropertyName("voltageConfigured")]
        public long VoltageConfigured { get; set; }

        [JsonPropertyName("voltageMin")]
        public long VoltageMin { get; set; }

        [JsonPropertyName("voltageMax")]
        public long VoltageMax { get; set; }
    }
}