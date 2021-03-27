using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Vms
    {
        [JsonPropertyName("domains")]
        public List<VmDomain> Domains { get; set; }
    }
}