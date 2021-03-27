namespace Sander0542.UnraidAPI.Types
{
    public enum ArrayState
    {
        Started,
        Stopped,
        NewArray,
        ReconDisk,
        DisableDisk,
        SwapDsbl,
        InvalidExpansion,
        ParityNotBiggest,
        TooManyMissingDisks,
        NewDiskTooSmall,
        NoDataDisks
    }
}