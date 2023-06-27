using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace StaticAbstraction.IO
{
    public interface IFile
    {
        void AppendAllLines(string path, IEnumerable<string> contents);
        void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding);
        void AppendAllText(string path, string contents);
        void AppendAllText(string path, string contents, Encoding encoding);
        StreamWriter AppendText(string path);
        void Copy(string sourceFileName, string destFileName);
        void Copy(string sourceFileName, string destFileName, bool overwrite);
        FileStream Create(string path);
        FileStream Create(string path, int bufferSize);
        FileStream Create(string path, int bufferSize, FileOptions options);

#if NETCORE60 || NETCORE70
        IFileSystemInfo CreateSymbolicLink(String path, String pathToTarget);
#endif
        StreamWriter CreateText(string path);
        void Decrypt(string path);
        void Encrypt(string path);
        bool Exists(string path);
        FileAttributes GetAttributes(string path);
        DateTime GetCreationTime(string path);
        DateTime GetCreationTimeUtc(string path);
        DateTime GetLastAccessTime(string path);
        DateTime GetLastAccessTimeUtc(string path);
        DateTime GetLastWriteTime(string path);
        DateTime GetLastWriteTimeUtc(string path);
        void Move(string sourceFileName, string destFileName);
        FileStream Open(string path, FileMode mode);

#if NETCORE60 || NETCORE70
        FileStream Open(String path, FileStreamOptions options);
#endif

        FileStream Open(string path, FileMode mode, FileAccess access);
        FileStream Open(string path, FileMode mode, FileAccess access, FileShare share);

#if NETCORE60 || NETCORE70
        SafeFileHandle OpenHandle(String path, FileMode mode, FileAccess access, FileShare share, FileOptions options, Int64 preallocationSize);
#endif

        FileStream OpenRead(string path);
        StreamReader OpenText(string path);
        FileStream OpenWrite(string path);
        byte[] ReadAllBytes(string path);
        string[] ReadAllLines(string path);
        string ReadAllText(string path);
        IEnumerable<string> ReadLines(string path);
        IEnumerable<string> ReadLines(string path, Encoding encoding);
        void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName);
        void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);

#if NETCORE60 || NETCORE70
        IFileSystemInfo ResolveLinkTarget(String linkPath, Boolean returnFinalTarget);
#endif
        void SetAttributes(string path, FileAttributes attributes);
        void SetCreationTime(string path, DateTime creationTime);
        void SetCreationTimeUtc(string path, DateTime creationTimeUtc);
        void SetLastAccessTime(string path, DateTime lastAccessTime);
        void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc);
        void SetLastWriteTime(string path, DateTime lastWriteTime);
        void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc);
        void WriteAllBytes(string path, byte[] bytes);
        void WriteAllLines(string path, IEnumerable<string> contents);
        void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding);
        void WriteAllLines(string path, string[] contents);
        void WriteAllLines(string path, string[] contents, Encoding encoding);
        void WriteAllText(string path, string contents);
        void WriteAllText(string path, string contents, Encoding encoding);

#if NETCORE22 || NETCORE30 || NETCORE31|| NETCORE50 || NETCORE60 || NETCORE70
        Task AppendAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = default(CancellationToken));
        Task AppendAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken));
        Task AppendAllTextAsync(string path, string contents, CancellationToken cancellationToken = default(CancellationToken));
        Task AppendAllTextAsync(string path, string contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken));
        Task<byte[]> ReadAllBytesAsync(string path);
        Task<string[]> ReadAllLinesAsync(string path);
        Task<string> ReadAllTextAsync(string path);
        Task WriteAllBytesAsync(string path, byte[] bytes);
        Task WriteAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = default(CancellationToken));
        Task WriteAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken));
        void WriteAllTextAsync(string path, string contents, CancellationToken cancellationToken = default(CancellationToken));
        void WriteAllTextAsync(string path, string contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken));
#endif

#if NETCORE30 || NETCORE31 || NETCORE50 || NETCORE60 || NETCORE70
        void Move(String sourceFileName, String destFileName, Boolean overwrite);
#endif

#if NETCORE70
        FileAttributes GetAttributes(SafeFileHandle fileHandle);
        DateTime GetCreationTime(SafeFileHandle fileHandle);
        DateTime GetCreationTimeUtc(SafeFileHandle fileHandle);
        DateTime GetLastAccessTime(SafeFileHandle fileHandle);
        DateTime GetLastAccessTimeUtc(SafeFileHandle fileHandle);
        DateTime GetLastWriteTime(SafeFileHandle fileHandle);
        DateTime GetLastWriteTimeUtc(SafeFileHandle fileHandle);
        UnixFileMode GetUnixFileMode(String path);
        UnixFileMode GetUnixFileMode(SafeFileHandle fileHandle);

        IAsyncEnumerable<String> ReadLinesAsync(String path, CancellationToken cancellationToken);
        IAsyncEnumerable<String> ReadLinesAsync(String path, Encoding encoding, CancellationToken cancellationToken);
        void SetAttributes(SafeFileHandle fileHandle, FileAttributes fileAttributes);
        void SetCreationTime(SafeFileHandle fileHandle, DateTime creationTime);
        void SetCreationTimeUtc(SafeFileHandle fileHandle, DateTime creationTimeUtc);
        void SetLastAccessTime(SafeFileHandle fileHandle, DateTime lastAccessTime);
        void SetLastAccessTimeUtc(SafeFileHandle fileHandle, DateTime lastAccessTimeUtc);
        void SetLastWriteTime(SafeFileHandle fileHandle, DateTime lastWriteTime);
        void SetLastWriteTimeUtc(SafeFileHandle fileHandle, DateTime lastWriteTimeUtc);
        void SetUnixFileMode(String path, UnixFileMode mode);
        void SetUnixFileMode(SafeFileHandle fileHandle, UnixFileMode mode);
#endif
    }
}
