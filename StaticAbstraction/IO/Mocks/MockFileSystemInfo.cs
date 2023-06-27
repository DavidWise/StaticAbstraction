using System;
using System.IO;
using System.Runtime.Serialization;

namespace StaticAbstraction.IO.Mocks
{
    public class MockFileSystemInfo : IFileSystemInfo
    {
        public virtual DateTime CreationTime { get; set; }
        public virtual DateTime CreationTimeUtc { get; set; }
        public virtual DateTime LastAccessTime { get; set; }
        public virtual DateTime LastAccessTimeUtc { get; set; }
        public virtual DateTime LastWriteTime { get; set; }
        public virtual DateTime LastWriteTimeUtc { get; set; }
        public virtual FileAttributes Attributes { get; set; }

        public virtual bool Exists { get; set; }

        public virtual string Name { get; set; }

        public virtual string Extension { get; set; }

        public virtual string FullName { get; set; }

#if NETCORE60 || NETCORE70
        public virtual string LinkTarget { get; set; }
#endif

        public virtual void Delete()
        {
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
        }

#if NETCORE60 || NETCORE70
        public virtual void CreateAsSymbolicLink(String pathToTarget)
        {
        }
#endif

        public virtual void Refresh()
        {
        }

#if NETCORE60 || NETCORE70
        public virtual IFileSystemInfo ResolveLinkTarget(Boolean returnFinalTarget)
        {
            return null;
        }
#endif
    }
}
