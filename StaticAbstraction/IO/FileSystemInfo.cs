using System;
using System.IO;
using System.Runtime.Serialization;

namespace StaticAbstraction.IO
{
    public class StAbFileSystemInfo : IFileSystemInfo
    {
        protected FileSystemInfo WrappedObject { get; private set; }

        public StAbFileSystemInfo(FileSystemInfo info)
        {
            WrappedObject = info;
        }

        public virtual DateTime LastWriteTime
        {
            get => WrappedObject.LastWriteTime;
            set => WrappedObject.LastWriteTime = value;
        }

        public virtual DateTime LastWriteTimeUtc
        {
            get => WrappedObject.LastWriteTimeUtc;
            set => WrappedObject.LastWriteTimeUtc = value;
        }

        public virtual DateTime CreationTime
        {
            get => WrappedObject.CreationTime;
            set => WrappedObject.CreationTime = value;
        }

        public virtual DateTime CreationTimeUtc
        {
            get => WrappedObject.CreationTimeUtc;
            set => WrappedObject.CreationTimeUtc = value;
        }

        public virtual DateTime LastAccessTime
        {
            get => WrappedObject.LastAccessTime;
            set => WrappedObject.LastAccessTime = value;
        }

        public virtual DateTime LastAccessTimeUtc
        {
            get => WrappedObject.LastAccessTimeUtc;
            set => WrappedObject.LastAccessTimeUtc = value;
        }

        public virtual FileAttributes Attributes
        {
            get => WrappedObject.Attributes;
            set => WrappedObject.Attributes = value;
        }

        public virtual string FullName => WrappedObject.FullName;
        public virtual string Extension => WrappedObject.Extension;

#if NETCORE60 || NETCORE70
        public virtual string LinkTarget => WrappedObject.LinkTarget;
#endif

#if NETCORE60 || NETCORE70
        public virtual void CreateAsSymbolicLink(String pathToTarget)
        {
            WrappedObject.CreateAsSymbolicLink(pathToTarget);
        }
#endif

        public virtual void Refresh()
        {
            WrappedObject.Refresh();
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            WrappedObject.GetObjectData(info, context);
        }

        public virtual bool Exists => WrappedObject.Exists;
        public virtual string Name => WrappedObject.Name;
        public virtual void Delete()
        {
            WrappedObject.Delete();
        }

#if NETCORE60 || NETCORE70
        public virtual IFileSystemInfo ResolveLinkTarget(Boolean returnFinalTarget)
        {
            var link = WrappedObject.ResolveLinkTarget(returnFinalTarget);
            if (link == null) { return null; }

            return new StAbFileSystemInfo(link);
        }
#endif
    }
}
