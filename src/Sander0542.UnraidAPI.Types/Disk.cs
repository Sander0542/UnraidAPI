using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Disk
    {
        [JsonPropertyName("device")]
        public string Device { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("vendor")]
        public string Vendor { get; set; }

        [JsonPropertyName("size")]
        public long Size { get; set; }

        [JsonPropertyName("bytesPerSector")]
        public long BytesPerSector { get; set; }

        [JsonPropertyName("totalCylinders")]
        public long TotalCylinders { get; set; }

        [JsonPropertyName("totalHeads")]
        public long TotalHeads { get; set; }

        [JsonPropertyName("totalSectors")]
        public long TotalSectors { get; set; }

        [JsonPropertyName("totalTracks")]
        public long TotalTracks { get; set; }

        [JsonPropertyName("tracksPerCylinder")]
        public long TracksPerCylinder { get; set; }

        [JsonPropertyName("sectorsPerTrack")]
        public long SectorsPerTrack { get; set; }

        [JsonPropertyName("firmwareRevision")]
        public string FirmwareRevision { get; set; }

        [JsonPropertyName("serialNum")]
        public string SerialNum { get; set; }

        [JsonPropertyName("interfaceType")]
        public DiskInterfaceType InterfaceType { get; set; }

        [JsonPropertyName("smartStatus")]
        public DiskSmartStatus SmartStatus { get; set; }

        [JsonPropertyName("temperature")]
        public long Temperature { get; set; }

        [JsonPropertyName("partitions")]
        public List<DiskPartition> Partitions { get; set; }
    }
}