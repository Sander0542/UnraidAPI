using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class SchedulerParameters
    {
        [JsonPropertyName("cpu_shares")]
        public int? CpuShares { get; set; }

        [JsonPropertyName("vcpu_period")]
        public int? VcpuPeriod { get; set; }

        [JsonPropertyName("vcpu_quota")]
        public int? VcpuQuota { get; set; }

        [JsonPropertyName("emulator_period")]
        public int? EmulatorPeriod { get; set; }

        [JsonPropertyName("emulator_quota")]
        public int? EmulatorQuota { get; set; }

        [JsonPropertyName("global_period")]
        public int? GlobalPeriod { get; set; }

        [JsonPropertyName("global_quota")]
        public int? GlobalQuota { get; set; }

        [JsonPropertyName("iothread_period")]
        public int? IothreadPeriod { get; set; }

        [JsonPropertyName("iothread_quota")]
        public int? IothreadQuota { get; set; }
    }
}