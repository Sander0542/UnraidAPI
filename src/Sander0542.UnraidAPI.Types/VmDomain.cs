using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class VmDomain
    {
        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        [JsonPropertyName("osType")]
        public string OsType { get; set; }

        [JsonPropertyName("autostart")]
        public bool? Autostart { get; set; }

        [JsonPropertyName("maxMemory")]
        public int? MaxMemory { get; set; }

        [JsonPropertyName("schedulerType")]
        public string SchedulerType { get; set; }

        [JsonPropertyName("schedulerParameters")]
        public SchedulerParameters SchedulerParameters { get; set; }

        [JsonPropertyName("securityLabel")]
        public SecurityLabel SecurityLabel { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("state")]
        public VmState? State { get; set; }

        [JsonPropertyName("memory")]
        public int? Memory { get; set; }

        [JsonPropertyName("vcpus")]
        public int? Vcpus { get; set; }

        [JsonPropertyName("cpuTime")]
        public int? CpuTime { get; set; }
    }
}