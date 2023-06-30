namespace StaticAbstraction.Diagnostics.Interface
{
#if NET40_OR_GREATER || NETCOREAPP3_0_OR_GREATER
    public interface IFileVersionInfo
    {
        IFileVersionInfoInstance GetVersionInfo(string fileName);
    }
#endif
}
