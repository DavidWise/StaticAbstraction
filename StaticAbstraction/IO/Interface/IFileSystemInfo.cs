﻿using System;
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

        void Delete();
        void Refresh();
        void GetObjectData(SerializationInfo info, StreamingContext context);
    }
}