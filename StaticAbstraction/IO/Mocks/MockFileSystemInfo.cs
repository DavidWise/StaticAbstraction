﻿using System;
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

        public virtual void Delete()
        {
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
        }

        public virtual void Refresh()
        {
        }
    }
}
