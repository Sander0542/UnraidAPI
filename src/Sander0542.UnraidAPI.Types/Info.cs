using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Info
    {
        [JsonPropertyName("apps")]
        public InfoApps Apps { get; set; }

        [JsonPropertyName("baseboard")]
        public Baseboard Baseboard { get; set; }

        [JsonPropertyName("cpu")]
        public InfoCpu Cpu { get; set; }

        [JsonPropertyName("devices")]
        public Devices Devices { get; set; }

        [JsonPropertyName("display")]
        public Display Display { get; set; }

        [JsonPropertyName("machineId")]
        public string MachineId { get; set; }

        [JsonPropertyName("memory")]
        public InfoMemory Memory { get; set; }

        [JsonPropertyName("os")]
        public Os Os { get; set; }

        [JsonPropertyName("system")]
        public System System { get; set; }

        [JsonPropertyName("versions")]
        public Versions Versions { get; set; }
    }
}