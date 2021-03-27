using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Mutation
    {
        [JsonPropertyName("login")]
        public string login { get; set; }

        [JsonPropertyName("shutdown")]
        public string shutdown { get; set; }

        [JsonPropertyName("reboot")]
        public string reboot { get; set; }

        [JsonPropertyName("testMutation")]
        public dynamic testMutation { get; set; }

        [JsonPropertyName("getApiKey")]
        public ApiKey getApiKey { get; set; }

        [JsonPropertyName("addApikey")]
        public ApiKey addApikey { get; set; }

        [JsonPropertyName("updateApikey")]
        public ApiKey updateApikey { get; set; }

        [JsonPropertyName("startArray")]
        public Array startArray { get; set; }

        [JsonPropertyName("stopArray")]
        public Array stopArray { get; set; }

        [JsonPropertyName("addDiskToArray")]
        public Array addDiskToArray { get; set; }

        [JsonPropertyName("removeDiskFromArray")]
        public Array removeDiskFromArray { get; set; }

        [JsonPropertyName("mountArrayDisk")]
        public Disk mountArrayDisk { get; set; }

        [JsonPropertyName("unmountArrayDisk")]
        public Disk unmountArrayDisk { get; set; }

        [JsonPropertyName("clearArrayDiskStatistics")]
        public dynamic clearArrayDiskStatistics { get; set; }

        [JsonPropertyName("startParityCheck")]
        public dynamic startParityCheck { get; set; }

        [JsonPropertyName("pauseParityCheck")]
        public dynamic pauseParityCheck { get; set; }

        [JsonPropertyName("resumeParityCheck")]
        public dynamic resumeParityCheck { get; set; }

        [JsonPropertyName("cancelParityCheck")]
        public dynamic cancelParityCheck { get; set; }

        [JsonPropertyName("addPlugin")]
        public dynamic addPlugin { get; set; }

        [JsonPropertyName("updatePlugin")]
        public dynamic updatePlugin { get; set; }

        [JsonPropertyName("removePlugin")]
        public dynamic removePlugin { get; set; }

        [JsonPropertyName("addScope")]
        public Scope addScope { get; set; }

        [JsonPropertyName("addScopeToApiKey")]
        public Scope addScopeToApiKey { get; set; }

        [JsonPropertyName("addUser")]
        public User addUser { get; set; }

        [JsonPropertyName("deleteUser")]
        public User deleteUser { get; set; }
    }
}
