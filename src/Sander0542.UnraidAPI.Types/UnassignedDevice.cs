using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class UnassignedDevice
    {
        [JsonPropertyName("devlinks")]
        public string Devlinks { get; set; }

        [JsonPropertyName("devname")]
        public string Devname { get; set; }

        [JsonPropertyName("devpath")]
        public string Devpath { get; set; }

        [JsonPropertyName("devtype")]
        public string Devtype { get; set; }

        [JsonPropertyName("idAta")]
        public string IdAta { get; set; }

        [JsonPropertyName("idAtaDownloadMicrocode")]
        public string IdAtaDownloadMicrocode { get; set; }

        [JsonPropertyName("idAtaFeatureSetAam")]
        public string IdAtaFeatureSetAam { get; set; }

        [JsonPropertyName("idAtaFeatureSetAamCurrentValue")]
        public string IdAtaFeatureSetAamCurrentValue { get; set; }

        [JsonPropertyName("idAtaFeatureSetAamEnabled")]
        public string IdAtaFeatureSetAamEnabled { get; set; }

        [JsonPropertyName("idAtaFeatureSetAamVendorRecommendedValue")]
        public string IdAtaFeatureSetAamVendorRecommendedValue { get; set; }

        [JsonPropertyName("idAtaFeatureSetApm")]
        public string IdAtaFeatureSetApm { get; set; }

        [JsonPropertyName("idAtaFeatureSetApmCurrentValue")]
        public string IdAtaFeatureSetApmCurrentValue { get; set; }

        [JsonPropertyName("idAtaFeatureSetApmEnabled")]
        public string IdAtaFeatureSetApmEnabled { get; set; }

        [JsonPropertyName("idAtaFeatureSetHpa")]
        public string IdAtaFeatureSetHpa { get; set; }

        [JsonPropertyName("idAtaFeatureSetHpaEnabled")]
        public string IdAtaFeatureSetHpaEnabled { get; set; }

        [JsonPropertyName("idAtaFeatureSetPm")]
        public string IdAtaFeatureSetPm { get; set; }

        [JsonPropertyName("idAtaFeatureSetPmEnabled")]
        public string IdAtaFeatureSetPmEnabled { get; set; }

        [JsonPropertyName("idAtaFeatureSetPuis")]
        public string IdAtaFeatureSetPuis { get; set; }

        [JsonPropertyName("idAtaFeatureSetPuisEnabled")]
        public string IdAtaFeatureSetPuisEnabled { get; set; }

        [JsonPropertyName("idAtaFeatureSetSecurity")]
        public string IdAtaFeatureSetSecurity { get; set; }

        [JsonPropertyName("idAtaFeatureSetSecurityEnabled")]
        public string IdAtaFeatureSetSecurityEnabled { get; set; }

        [JsonPropertyName("idAtaFeatureSetSecurityEnhancedEraseUnitMin")]
        public string IdAtaFeatureSetSecurityEnhancedEraseUnitMin { get; set; }

        [JsonPropertyName("idAtaFeatureSetSecurityEraseUnitMin")]
        public string IdAtaFeatureSetSecurityEraseUnitMin { get; set; }

        [JsonPropertyName("idAtaFeatureSetSmart")]
        public string IdAtaFeatureSetSmart { get; set; }

        [JsonPropertyName("idAtaFeatureSetSmartEnabled")]
        public string IdAtaFeatureSetSmartEnabled { get; set; }

        [JsonPropertyName("idAtaRotationRateRpm")]
        public string IdAtaRotationRateRpm { get; set; }

        [JsonPropertyName("idAtaSata")]
        public string IdAtaSata { get; set; }

        [JsonPropertyName("idAtaSataSignalRateGen1")]
        public string IdAtaSataSignalRateGen1 { get; set; }

        [JsonPropertyName("idAtaSataSignalRateGen2")]
        public string IdAtaSataSignalRateGen2 { get; set; }

        [JsonPropertyName("idAtaWriteCache")]
        public string IdAtaWriteCache { get; set; }

        [JsonPropertyName("idAtaWriteCacheEnabled")]
        public string IdAtaWriteCacheEnabled { get; set; }

        [JsonPropertyName("idBus")]
        public string IdBus { get; set; }

        [JsonPropertyName("idModel")]
        public string IdModel { get; set; }

        [JsonPropertyName("idModelEnc")]
        public string IdModelEnc { get; set; }

        [JsonPropertyName("idPartTableType")]
        public string IdPartTableType { get; set; }

        [JsonPropertyName("idPath")]
        public string IdPath { get; set; }

        [JsonPropertyName("idPathTag")]
        public string IdPathTag { get; set; }

        [JsonPropertyName("idRevision")]
        public string IdRevision { get; set; }

        [JsonPropertyName("idSerial")]
        public string IdSerial { get; set; }

        [JsonPropertyName("idSerialShort")]
        public string IdSerialShort { get; set; }

        [JsonPropertyName("idType")]
        public string IdType { get; set; }

        [JsonPropertyName("idWwn")]
        public string IdWwn { get; set; }

        [JsonPropertyName("idWwnWithExtension")]
        public string IdWwnWithExtension { get; set; }

        [JsonPropertyName("major")]
        public string Major { get; set; }

        [JsonPropertyName("minor")]
        public string Minor { get; set; }

        [JsonPropertyName("subsystem")]
        public string Subsystem { get; set; }

        [JsonPropertyName("usecInitialized")]
        public string UsecInitialized { get; set; }

        [JsonPropertyName("partitions")]
        public List<Partition> Partitions { get; set; }

        [JsonPropertyName("temp")]
        public int? Temp { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("mounted")]
        public bool? Mounted { get; set; }

        [JsonPropertyName("mount")]
        public Mount Mount { get; set; }
    }
}