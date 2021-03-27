using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class ArrayDataDisk
    {
        [JsonPropertyName("slot")]
        public long Slot { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("device")]
        public string Device { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("size")]
        public long Size { get; set; }

        [JsonPropertyName("status")]
        public ArrayDiskStatus Status { get; set; }

        [JsonPropertyName("rotational")]
        public bool Rotational { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonPropertyName("temp")]
        public int Temp { get; set; }

        [JsonPropertyName("numReads")]
        public int NumReads { get; set; }

        [JsonPropertyName("numWrites")]
        public int NumWrites { get; set; }

        [JsonPropertyName("numErrors")]
        public int NumErrors { get; set; }

        [JsonPropertyName("type")]
        public ArrayDiskType Type { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("fsStatus")]
        public string FsStatus { get; set; }

        [JsonPropertyName("luksState")]
        public string LuksState { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("exportable")]
        public bool Exportable { get; set; }

        [JsonPropertyName("fsType")]
        public DiskFsType? FsType { get; set; }

        [JsonPropertyName("fsColor")]
        public ArrayDiskFsColor? FsColor { get; set; }

        [JsonPropertyName("fsSize")]
        public long FsSize { get; set; }

        [JsonPropertyName("fsFree")]
        public long FsFree { get; set; }

        [JsonPropertyName("spindownDelay")]
        public string SpindownDelay { get; set; }

        [JsonPropertyName("spinupGroup")]
        public string SpinupGroup { get; set; }

        [JsonPropertyName("deviceSb")]
        public string DeviceSb { get; set; }

        [JsonPropertyName("idSb")]
        public string IdSb { get; set; }

        [JsonPropertyName("sizeSb")]
        public long SizeSb { get; set; }
    }
}