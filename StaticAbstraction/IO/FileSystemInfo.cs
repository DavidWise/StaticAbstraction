using System;
using System.IO;
using System.Runtime.Serialization;

namespace StaticAbstraction.IO
{
    public abstract class StAbFileSystemInfo : IFileSystemInfo
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

        public virtual void Refresh()
        {
            WrappedObject.Refresh();
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            WrappedObject.GetObjectData(info, context);
        }

        public abstract bool Exists { get; }
        public abstract string Name { get; }
        public abstract void Delete();
    }
}
