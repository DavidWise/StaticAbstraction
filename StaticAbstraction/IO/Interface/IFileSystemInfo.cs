using System;
using System.IO;
using System.Runtime.Serialization;

namespace StaticAbstraction.IO
{
    public interface IFileSystemInfo
    {
        DateTime CreationTime { get; set; }
        DateTime CreationTimeUtc { get; set; }
        DateTime LastAccessTime { get; set; }
        DateTime LastAccessTimeUtc { get; set; }
        DateTime LastWriteTime { get; set; }
        DateTime LastWriteTimeUtc { get; set; }
        FileAttributes Attributes { get; set; }
        bool Exists { get; }
        string Name { get; }
        string Extension { get; }
        string FullName { get; }

#if NETCORE60 || NETCORE70
        string LinkTarget { get; }
#endif

#if NETCORE70
        UnixFileMode UnixFileMode { get; set; }
#endif

#if NETCORE60 || NETCORE70
        void CreateAsSymbolicLink(String pathToTarget);
#endif

        void Delete();
        void Refresh();

#if NETCORE60 || NETCORE70
        IFileSystemInfo ResolveLinkTarget(Boolean returnFinalTarget);
#endif
        void GetObjectData(SerializationInfo info, StreamingContext context);
    }
}