using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class InfoCpu
    {
        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        [JsonPropertyName("vendor")]
        public string Vendor { get; set; }

        [JsonPropertyName("family")]
        public string Family { get; set; }

        [JsonPropertyName("model")]
        public string Model { get; set; }

        [JsonPropertyName("stepping")]
        public int Stepping { get; set; }

        [JsonPropertyName("revision")]
        public string Revision { get; set; }

        [JsonPropertyName("voltage")]
        public string Voltage { get; set; }

        [JsonPropertyName("speed")]
        public float Speed { get; set; }

        [JsonPropertyName("speedmin")]
        public float Speedmin { get; set; }

        [JsonPropertyName("speedmax")]
        public float Speedmax { get; set; }

        [JsonPropertyName("threads")]
        public int Threads { get; set; }

        [JsonPropertyName("cores")]
        public int Cores { get; set; }

        [JsonPropertyName("processors")]
        public long Processors { get; set; }

        [JsonPropertyName("socket")]
        public string Socket { get; set; }

        [JsonPropertyName("cache")]
        public long Cache { get; set; }

        [JsonPropertyName("flags")]
        public List<string> Flags { get; set; }
    }
}