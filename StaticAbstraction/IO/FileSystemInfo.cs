using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace StaticAbstraction.IO
{
    public abstract class StAbFileSystemInfo : IFileSystemInfo
    {
        protected FileSystemInfo BaseInfo { get; private set; }

        public StAbFileSystemInfo(FileSystemInfo info)
        {
            BaseInfo = info;
        }

        public DateTime LastWriteTime
        {
            get => BaseInfo.LastWriteTime;
            set => BaseInfo.LastWriteTime = value;
        }

        public DateTime LastWriteTimeUtc
        {
            get => BaseInfo.LastWriteTimeUtc;
            set => BaseInfo.LastWriteTimeUtc = value;
        }

        public DateTime CreationTime
        {
            get => BaseInfo.CreationTime;
            set => BaseInfo.CreationTime = value;
        }

        public DateTime CreationTimeUtc
        {
            get => BaseInfo.CreationTimeUtc;
            set => BaseInfo.CreationTimeUtc = value;
        }

        public DateTime LastAccessTime
        {
            get => BaseInfo.LastAccessTime;
            set => BaseInfo.LastAccessTime = value;
        }

        public DateTime LastAccessTimeUtc
        {
            get => BaseInfo.LastAccessTimeUtc;
            set => BaseInfo.LastAccessTimeUtc = value;
        }

        public FileAttributes Attributes
        {
            get => BaseInfo.Attributes;
            set => BaseInfo.Attributes = value;
        }

        public abstract bool Exists { get; }
        public virtual string FullName { get; }
        public abstract string Name { get; }
        public string Extension => BaseInfo.Extension;

        public abstract void Delete();

        public virtual void Refresh()
        {
            BaseInfo.Refresh();
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            BaseInfo.GetObjectData(info, context);
        }
    }
}
