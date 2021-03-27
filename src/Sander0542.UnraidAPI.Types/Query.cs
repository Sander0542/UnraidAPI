using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Query
    {
        [JsonPropertyName("welcome")]
        public Welcome Welcome { get; set; }

        [JsonPropertyName("online")]
        public bool Online { get; set; }

        [JsonPropertyName("info")]
        public Info Info { get; set; }

        [JsonPropertyName("pluginModule")]
        public dynamic PluginModule { get; set; }

        [JsonPropertyName("testQuery")]
        public dynamic TestQuery { get; set; }

        [JsonPropertyName("context")]
        public Context Context { get; set; }

        [JsonPropertyName("apiKeys")]
        public List<ApiKey> ApiKeys { get; set; }

        [JsonPropertyName("array")]
        public Array Array { get; set; }

        [JsonPropertyName("parityHistory")]
        public List<ParityCheck> ParityHistory { get; set; }

        [JsonPropertyName("device")]
        public Device Device { get; set; }

        [JsonPropertyName("devices")]
        public List<Device> Devices { get; set; }

        [JsonPropertyName("disk")]
        public Disk Disk { get; set; }

        [JsonPropertyName("disks")]
        public List<Disk> Disks { get; set; }

        [JsonPropertyName("display")]
        public Display Display { get; set; }

        [JsonPropertyName("dockerContainer")]
        public DockerContainer DockerContainer { get; set; }

        [JsonPropertyName("dockerContainers")]
        public List<DockerContainer> DockerContainers { get; set; }

        [JsonPropertyName("dockerNetwork")]
        public DockerNetwork DockerNetwork { get; set; }

        [JsonPropertyName("dockerNetworks")]
        public List<DockerNetwork> DockerNetworks { get; set; }

        [JsonPropertyName("plugins")]
        public List<Plugin> Plugins { get; set; }

        [JsonPropertyName("permissions")]
        public Permissions Permissions { get; set; }

        [JsonPropertyName("server")]
        public Server Server { get; set; }

        [JsonPropertyName("servers")]
        public List<Server> Servers { get; set; }

        [JsonPropertyName("service")]
        public Service Service { get; set; }

        [JsonPropertyName("services")]
        public List<Service> Services { get; set; }

        [JsonPropertyName("shares")]
        public List<Share> Shares { get; set; }

        [JsonPropertyName("unassignedDevices")]
        public List<UnassignedDevice> UnassignedDevices { get; set; }

        [JsonPropertyName("uptime")]
        public Uptime Uptime { get; set; }

        [JsonPropertyName("me")]
        public Me Me { get; set; }

        [JsonPropertyName("user")]
        public User User { get; set; }

        [JsonPropertyName("users")]
        public List<User> Users { get; set; }

        [JsonPropertyName("vars")]
        public Vars Vars { get; set; }

        [JsonPropertyName("vm")]
        public VmDomain Vm { get; set; }

        [JsonPropertyName("vms")]
        public Vms Vms { get; set; }

        [JsonPropertyName("vmNetwork")]
        public dynamic VmNetwork { get; set; }
    }
}