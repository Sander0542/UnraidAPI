using System.Text.Json.Serialization;

namespace Sander0542.UnraidAPI.Types
{
    public class Vars
    {
        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("maxArraysz")]
        public int? MaxArraysz { get; set; }

        [JsonPropertyName("maxCachesz")]
        public int? MaxCachesz { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("timeZone")]
        public string TimeZone { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("security")]
        public string Security { get; set; }

        [JsonPropertyName("workgroup")]
        public string Workgroup { get; set; }

        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        [JsonPropertyName("domainShort")]
        public string DomainShort { get; set; }

        [JsonPropertyName("hideDotFiles")]
        public bool? HideDotFiles { get; set; }

        [JsonPropertyName("localMaster")]
        public bool? LocalMaster { get; set; }

        [JsonPropertyName("enableFruit")]
        public string EnableFruit { get; set; }

        [JsonPropertyName("useNtp")]
        public bool? UseNtp { get; set; }

        [JsonPropertyName("ntpServer1")]
        public string NtpServer1 { get; set; }

        [JsonPropertyName("ntpServer2")]
        public string NtpServer2 { get; set; }

        [JsonPropertyName("ntpServer3")]
        public string NtpServer3 { get; set; }

        [JsonPropertyName("ntpServer4")]
        public string NtpServer4 { get; set; }

        [JsonPropertyName("domainLogin")]
        public string DomainLogin { get; set; }

        [JsonPropertyName("sysModel")]
        public string SysModel { get; set; }

        [JsonPropertyName("sysArraySlots")]
        public int? SysArraySlots { get; set; }

        [JsonPropertyName("sysCacheSlots")]
        public int? SysCacheSlots { get; set; }

        [JsonPropertyName("sysFlashSlots")]
        public int? SysFlashSlots { get; set; }

        [JsonPropertyName("useSsl")]
        public bool? UseSsl { get; set; }

        [JsonPropertyName("port")]
        public int? Port { get; set; }

        [JsonPropertyName("portssl")]
        public int? Portssl { get; set; }

        [JsonPropertyName("localTld")]
        public string LocalTld { get; set; }

        [JsonPropertyName("bindMgt")]
        public bool? BindMgt { get; set; }

        [JsonPropertyName("useTelnet")]
        public bool? UseTelnet { get; set; }

        [JsonPropertyName("porttelnet")]
        public int? Porttelnet { get; set; }

        [JsonPropertyName("useSsh")]
        public bool? UseSsh { get; set; }

        [JsonPropertyName("portssh")]
        public int? Portssh { get; set; }

        [JsonPropertyName("startPage")]
        public string StartPage { get; set; }

        [JsonPropertyName("startArray")]
        public bool? StartArray { get; set; }

        [JsonPropertyName("spindownDelay")]
        public string SpindownDelay { get; set; }

        [JsonPropertyName("queueDepth")]
        public string QueueDepth { get; set; }

        [JsonPropertyName("spinupGroups")]
        public bool? SpinupGroups { get; set; }

        [JsonPropertyName("defaultFormat")]
        public string DefaultFormat { get; set; }

        [JsonPropertyName("defaultFsType")]
        public string DefaultFsType { get; set; }

        [JsonPropertyName("shutdownTimeout")]
        public int? ShutdownTimeout { get; set; }

        [JsonPropertyName("luksKeyfile")]
        public string LuksKeyfile { get; set; }

        [JsonPropertyName("pollAttributes")]
        public string PollAttributes { get; set; }

        [JsonPropertyName("pollAttributesDefault")]
        public string PollAttributesDefault { get; set; }

        [JsonPropertyName("pollAttributesStatus")]
        public string PollAttributesStatus { get; set; }

        [JsonPropertyName("nrRequests")]
        public int? NrRequests { get; set; }

        [JsonPropertyName("nrRequestsDefault")]
        public int? NrRequestsDefault { get; set; }

        [JsonPropertyName("nrRequestsStatus")]
        public string NrRequestsStatus { get; set; }

        [JsonPropertyName("mdNumStripes")]
        public int? MdNumStripes { get; set; }

        [JsonPropertyName("mdNumStripesDefault")]
        public int? MdNumStripesDefault { get; set; }

        [JsonPropertyName("mdNumStripesStatus")]
        public string MdNumStripesStatus { get; set; }

        [JsonPropertyName("mdSyncWindow")]
        public int? MdSyncWindow { get; set; }

        [JsonPropertyName("mdSyncWindowDefault")]
        public int? MdSyncWindowDefault { get; set; }

        [JsonPropertyName("mdSyncWindowStatus")]
        public string MdSyncWindowStatus { get; set; }

        [JsonPropertyName("mdSyncThresh")]
        public int? MdSyncThresh { get; set; }

        [JsonPropertyName("mdSyncThreshDefault")]
        public int? MdSyncThreshDefault { get; set; }

        [JsonPropertyName("mdSyncThreshStatus")]
        public string MdSyncThreshStatus { get; set; }

        [JsonPropertyName("mdWriteMethod")]
        public int? MdWriteMethod { get; set; }

        [JsonPropertyName("mdWriteMethodDefault")]
        public string MdWriteMethodDefault { get; set; }

        [JsonPropertyName("mdWriteMethodStatus")]
        public string MdWriteMethodStatus { get; set; }

        [JsonPropertyName("shareDisk")]
        public string ShareDisk { get; set; }

        [JsonPropertyName("shareUser")]
        public string ShareUser { get; set; }

        [JsonPropertyName("shareUserInclude")]
        public string ShareUserInclude { get; set; }

        [JsonPropertyName("shareUserExclude")]
        public string ShareUserExclude { get; set; }

        [JsonPropertyName("shareSmbEnabled")]
        public bool? ShareSmbEnabled { get; set; }

        [JsonPropertyName("shareNfsEnabled")]
        public bool? ShareNfsEnabled { get; set; }

        [JsonPropertyName("shareAfpEnabled")]
        public bool? ShareAfpEnabled { get; set; }

        [JsonPropertyName("shareInitialOwner")]
        public string ShareInitialOwner { get; set; }

        [JsonPropertyName("shareInitialGroup")]
        public string ShareInitialGroup { get; set; }

        [JsonPropertyName("shareCacheEnabled")]
        public bool? ShareCacheEnabled { get; set; }

        [JsonPropertyName("shareCacheFloor")]
        public string ShareCacheFloor { get; set; }

        [JsonPropertyName("shareMoverSchedule")]
        public string ShareMoverSchedule { get; set; }

        [JsonPropertyName("shareMoverLogging")]
        public bool? ShareMoverLogging { get; set; }

        [JsonPropertyName("fuseRemember")]
        public string FuseRemember { get; set; }

        [JsonPropertyName("fuseRememberDefault")]
        public string FuseRememberDefault { get; set; }

        [JsonPropertyName("fuseRememberStatus")]
        public string FuseRememberStatus { get; set; }

        [JsonPropertyName("fuseDirectio")]
        public string FuseDirectio { get; set; }

        [JsonPropertyName("fuseDirectioDefault")]
        public string FuseDirectioDefault { get; set; }

        [JsonPropertyName("fuseDirectioStatus")]
        public string FuseDirectioStatus { get; set; }

        [JsonPropertyName("shareAvahiEnabled")]
        public bool? ShareAvahiEnabled { get; set; }

        [JsonPropertyName("shareAvahiSmbName")]
        public string ShareAvahiSmbName { get; set; }

        [JsonPropertyName("shareAvahiSmbModel")]
        public string ShareAvahiSmbModel { get; set; }

        [JsonPropertyName("shareAvahiAfpName")]
        public string ShareAvahiAfpName { get; set; }

        [JsonPropertyName("shareAvahiAfpModel")]
        public string ShareAvahiAfpModel { get; set; }

        [JsonPropertyName("safeMode")]
        public bool? SafeMode { get; set; }

        [JsonPropertyName("startMode")]
        public string StartMode { get; set; }

        [JsonPropertyName("configValid")]
        public bool? ConfigValid { get; set; }

        [JsonPropertyName("joinStatus")]
        public string JoinStatus { get; set; }

        [JsonPropertyName("deviceCount")]
        public int? DeviceCount { get; set; }

        [JsonPropertyName("flashGuid")]
        public string FlashGuid { get; set; }

        [JsonPropertyName("flashProduct")]
        public string FlashProduct { get; set; }

        [JsonPropertyName("flashVendor")]
        public string FlashVendor { get; set; }

        [JsonPropertyName("regCheck")]
        public string RegCheck { get; set; }

        [JsonPropertyName("regFile")]
        public string RegFile { get; set; }

        [JsonPropertyName("regGuid")]
        public string RegGuid { get; set; }

        [JsonPropertyName("regTy")]
        public RegistationType? RegTy { get; set; }

        [JsonPropertyName("regTo")]
        public string RegTo { get; set; }

        [JsonPropertyName("regTm")]
        public string RegTm { get; set; }

        [JsonPropertyName("regTm2")]
        public string RegTm2 { get; set; }

        [JsonPropertyName("regGen")]
        public string RegGen { get; set; }

        [JsonPropertyName("sbName")]
        public string SbName { get; set; }

        [JsonPropertyName("sbVersion")]
        public string SbVersion { get; set; }

        [JsonPropertyName("sbUpdated")]
        public string SbUpdated { get; set; }

        [JsonPropertyName("sbEvents")]
        public int? SbEvents { get; set; }

        [JsonPropertyName("sbState")]
        public string SbState { get; set; }

        [JsonPropertyName("sbClean")]
        public bool? SbClean { get; set; }

        [JsonPropertyName("sbSynced")]
        public int? SbSynced { get; set; }

        [JsonPropertyName("sbSyncErrs")]
        public int? SbSyncErrs { get; set; }

        [JsonPropertyName("sbSynced2")]
        public int? SbSynced2 { get; set; }

        [JsonPropertyName("sbSyncExit")]
        public string SbSyncExit { get; set; }

        [JsonPropertyName("sbNumDisks")]
        public int? SbNumDisks { get; set; }

        [JsonPropertyName("mdColor")]
        public string MdColor { get; set; }

        [JsonPropertyName("mdNumDisks")]
        public int? MdNumDisks { get; set; }

        [JsonPropertyName("mdNumDisabled")]
        public int? MdNumDisabled { get; set; }

        [JsonPropertyName("mdNumInvalid")]
        public int? MdNumInvalid { get; set; }

        [JsonPropertyName("mdNumMissing")]
        public int? MdNumMissing { get; set; }

        [JsonPropertyName("mdNumNew")]
        public int? MdNumNew { get; set; }

        [JsonPropertyName("mdNumErased")]
        public int? MdNumErased { get; set; }

        [JsonPropertyName("mdResync")]
        public int? MdResync { get; set; }

        [JsonPropertyName("mdResyncCorr")]
        public string MdResyncCorr { get; set; }

        [JsonPropertyName("mdResyncPos")]
        public string MdResyncPos { get; set; }

        [JsonPropertyName("mdResyncDb")]
        public string MdResyncDb { get; set; }

        [JsonPropertyName("mdResyncDt")]
        public string MdResyncDt { get; set; }

        [JsonPropertyName("mdResyncAction")]
        public string MdResyncAction { get; set; }

        [JsonPropertyName("mdResyncSize")]
        public int? MdResyncSize { get; set; }

        [JsonPropertyName("mdState")]
        public string MdState { get; set; }

        [JsonPropertyName("mdVersion")]
        public string MdVersion { get; set; }

        [JsonPropertyName("cacheNumDevices")]
        public int? CacheNumDevices { get; set; }

        [JsonPropertyName("cacheSbNumDisks")]
        public int? CacheSbNumDisks { get; set; }

        [JsonPropertyName("fsState")]
        public string FsState { get; set; }

        [JsonPropertyName("fsProgress")]
        public string FsProgress { get; set; }

        [JsonPropertyName("fsCopyPrcnt")]
        public int? FsCopyPrcnt { get; set; }

        [JsonPropertyName("fsNumMounted")]
        public int? FsNumMounted { get; set; }

        [JsonPropertyName("fsNumUnmountable")]
        public int? FsNumUnmountable { get; set; }

        [JsonPropertyName("fsUnmountableMask")]
        public string FsUnmountableMask { get; set; }

        [JsonPropertyName("shareCount")]
        public int? ShareCount { get; set; }

        [JsonPropertyName("shareSmbCount")]
        public int? ShareSmbCount { get; set; }

        [JsonPropertyName("shareNfsCount")]
        public int? ShareNfsCount { get; set; }

        [JsonPropertyName("shareAfpCount")]
        public int? ShareAfpCount { get; set; }

        [JsonPropertyName("shareMoverActive")]
        public bool? ShareMoverActive { get; set; }

        [JsonPropertyName("csrfToken")]
        public string CsrfToken { get; set; }

        [JsonPropertyName("uptime")]
        public string Uptime { get; set; }
    }
}