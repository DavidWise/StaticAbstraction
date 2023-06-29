using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StaticAbstraction.IO
{
    public  class StAbFile : IFile
    {
        public virtual void AppendAllLines(string path, IEnumerable<string> contents)
        {
            File.AppendAllLines(path, contents);
        }
        public virtual void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding)
        {
            File.AppendAllLines(path, contents, encoding);
        }



        public virtual void AppendAllText(string path, string contents)
        {
            File.AppendAllText(path, contents);
        }
        public virtual void AppendAllText(string path, string contents, Encoding encoding)
        {
            File.AppendAllText(path, contents, encoding);
        }



        public virtual StreamWriter AppendText(string path)
        {
            return File.AppendText(path);
        }

        public virtual void Copy(string sourceFileName, string destFileName)
        {
            File.Copy(sourceFileName, destFileName);
        }
        public virtual void Copy(string sourceFileName, string destFileName, bool overwrite)
        {
            File.Copy(sourceFileName, destFileName, overwrite);
        }

        public virtual FileStream Create(string path)
        {
            return File.Create(path);
        }
        public virtual FileStream Create(string path, int bufferSize)
        {
            return File.Create(path, bufferSize);
        }
        public virtual FileStream Create(string path, int bufferSize, FileOptions options)
        {
            return File.Create(path, bufferSize, options);
        }

#if NET6_0_OR_GREATER
        public virtual IFileSystemInfo CreateSymbolicLink(String path, String pathToTarget)
        {
            var link = File.CreateSymbolicLink(path, pathToTarget); 
            if (link != null) return new StAbFileSystemInfo(link);
            return null;
        }
#endif

        public virtual StreamWriter CreateText(string path)
        {
            return File.CreateText(path);
        }

        public virtual void Decrypt(string path)
        {
            File.Decrypt(path);
        }
        public virtual void Encrypt(string path)
        {
            File.Encrypt(path);
        }

        public virtual bool Exists(string path)
        {
            return File.Exists(path);
        }

        public virtual FileAttributes GetAttributes(string path)
        {
            return File.GetAttributes(path);
        }

        public virtual DateTime GetCreationTime(string path)
        {
            return File.GetCreationTime(path);
        }
        public virtual DateTime GetCreationTimeUtc(string path)
        {
            return File.GetCreationTimeUtc(path);
        }

        public virtual DateTime GetLastAccessTime(string path)
        {
            return File.GetLastAccessTime(path);
        }
        public virtual DateTime GetLastAccessTimeUtc(string path)
        {
            return File.GetLastAccessTimeUtc(path);
        }

        public virtual DateTime GetLastWriteTime(string path)
        {
            return File.GetLastWriteTime(path);
        }
        public virtual DateTime GetLastWriteTimeUtc(string path)
        {
            return File.GetLastWriteTimeUtc(path);
        }

        public virtual void Move(string sourceFileName, string destFileName)
        {
            File.Move(sourceFileName, destFileName);
        }

#if NETCOREAPP3_0_OR_GREATER
        public virtual void Move(String sourceFileName, String destFileName, Boolean overwrite)
        {
            File.Move(sourceFileName, destFileName, overwrite);
        }
#endif

        public virtual FileStream Open(string path, FileMode mode)
        {
            return File.Open(path, mode);
        }


#if NET6_0_OR_GREATER
        public virtual FileStream Open(String path, FileStreamOptions options)
        {
            return File.Open(path, options);
        }
#endif

        public virtual FileStream Open(string path, FileMode mode, FileAccess access)
        {
            return File.Open(path, mode, access);
        }
        public virtual FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
        {
            return File.Open(path, mode, access, share);
        }

#if NET6_0_OR_GREATER
        public virtual SafeFileHandle OpenHandle(String path, FileMode mode, FileAccess access, FileShare share, FileOptions options, Int64 preallocationSize)
        {
            return File.OpenHandle(path, mode, access, share, options, preallocationSize);
        }
#endif


        public virtual FileStream OpenRead(string path)
        {
            return File.OpenRead(path);
        }

        public virtual StreamReader OpenText(string path)
        {
            return File.OpenText(path);
        }

        public virtual FileStream OpenWrite(string path)
        {
            return File.OpenWrite(path);
        }

        public virtual byte[] ReadAllBytes(string path)
        {
            return File.ReadAllBytes(path);
        }


        public virtual string[] ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }


        public virtual string ReadAllText(string path)
        {
            return File.ReadAllText(path);
        }


        public virtual IEnumerable<string> ReadLines(string path)
        {
            return File.ReadLines(path);
        }
        public virtual IEnumerable<string> ReadLines(string path, Encoding encoding)
        {
            return File.ReadLines(path, encoding);
        }

        public virtual void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName)
        {
            File.Replace(sourceFileName, destinationFileName, destinationBackupFileName);
        }
        public virtual void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            File.Replace(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
        }

#if NET6_0_OR_GREATER
        public IFileSystemInfo ResolveLinkTarget(String linkPath, Boolean returnFinalTarget)
        {
            var link = File.ResolveLinkTarget(linkPath, returnFinalTarget);
            if (link == null) return null;

            return new StAbFileSystemInfo(link);
        }
#endif

        public virtual void SetAttributes(string path, FileAttributes attributes)
        {
            File.SetAttributes(path, attributes);
        }

        public virtual void SetCreationTime(string path, DateTime creationTime)
        {
            File.SetCreationTime(path, creationTime);
        }
        public virtual void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
        {
            File.SetCreationTimeUtc(path, creationTimeUtc);
        }

        public virtual void SetLastAccessTime(string path, DateTime lastAccessTime)
        {
            File.SetLastAccessTime(path, lastAccessTime);
        }
        public virtual void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        {
            File.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
        }

        public virtual void SetLastWriteTime(string path, DateTime lastWriteTime)
        {
            File.SetLastWriteTime(path, lastWriteTime);
        }
        public virtual void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        {
            File.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
        }


        public virtual void WriteAllBytes(string path, byte[] bytes)
        {
            File.WriteAllBytes(path, bytes);
        }


        public virtual void WriteAllLines(string path, string[] contents)
        {
            File.WriteAllLines(path, contents);
        }
        public virtual void WriteAllLines(string path, string[] contents, Encoding encoding)
        {
            File.WriteAllLines(path, contents, encoding);
        }
        public virtual void WriteAllLines(string path, IEnumerable<string> contents)
        {
            File.WriteAllLines(path, contents);
        }
        public virtual void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding)
        {
            File.WriteAllLines(path, contents, encoding);
        }



        public virtual void WriteAllText(string path, string contents)
        {
            File.WriteAllText(path, contents);
        }
        public virtual void WriteAllText(string path, string contents, Encoding encoding)
        {
            File.WriteAllText(path, contents, encoding);
        }



#if NETCOREAPP2_2_OR_GREATER
        public virtual Task AppendAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = default(CancellationToken))
        {
            return File.AppendAllLinesAsync(path, contents, cancellationToken);
        }
        public virtual Task AppendAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
        {
            return File.AppendAllLinesAsync(path, contents, encoding, cancellationToken);
        }
        public virtual Task AppendAllTextAsync(string path, string contents, CancellationToken cancellationToken = default(CancellationToken))
        {
            return File.AppendAllTextAsync(path, contents, cancellationToken);
        }
        public virtual Task AppendAllTextAsync(string path, string contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
        {
            return File.AppendAllTextAsync(path, contents, encoding, cancellationToken);
        }
        public virtual Task<byte[]> ReadAllBytesAsync(string path)
        {
            return File.ReadAllBytesAsync(path);
        }
        public virtual Task<string[]> ReadAllLinesAsync(string path)
        {
            return File.ReadAllLinesAsync(path);
        }
        public virtual Task<string> ReadAllTextAsync(string path)
        {
            return File.ReadAllTextAsync(path);
        }
        public virtual Task WriteAllBytesAsync(string path, byte[] bytes)
        {
            return File.WriteAllBytesAsync(path, bytes);
        }
        public virtual Task WriteAllLinesAsync(string path, IEnumerable<string> contents, CancellationToken cancellationToken = default(CancellationToken))
        {
            return File.WriteAllLinesAsync(path, contents, cancellationToken);
        }
        public virtual Task WriteAllLinesAsync(string path, IEnumerable<string> contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
        {
            return File.WriteAllLinesAsync(path, contents, encoding, cancellationToken);
        }
        public virtual void WriteAllTextAsync(string path, string contents, CancellationToken cancellationToken = default(CancellationToken))
        {
            File.WriteAllTextAsync(path, contents, cancellationToken);
        }
        public virtual void WriteAllTextAsync(string path, string contents, Encoding encoding, CancellationToken cancellationToken = default(CancellationToken))
        {
            File.WriteAllTextAsync(path, contents, encoding, cancellationToken);
        }
#endif

#if NET7_0_OR_GREATER
        public virtual FileAttributes GetAttributes(SafeFileHandle fileHandle) {
            return File.GetAttributes(fileHandle);
        }
        public virtual DateTime GetCreationTime(SafeFileHandle fileHandle) {
            return File.GetCreationTime(fileHandle);
        }
        public virtual DateTime GetCreationTimeUtc(SafeFileHandle fileHandle) {
            return File.GetCreationTimeUtc(fileHandle);
        }
        public virtual DateTime GetLastAccessTime(SafeFileHandle fileHandle) {
            return File.GetLastAccessTime(fileHandle);
        }
        public virtual DateTime GetLastAccessTimeUtc(SafeFileHandle fileHandle) {
            return File.GetLastAccessTimeUtc(fileHandle);
        }
        public virtual DateTime GetLastWriteTime(SafeFileHandle fileHandle) {
            return File.GetLastWriteTime(fileHandle);
        }
        public virtual DateTime GetLastWriteTimeUtc(SafeFileHandle fileHandle) {
            return File.GetLastWriteTimeUtc(fileHandle);
        }
        public virtual UnixFileMode GetUnixFileMode(String path) {
            return File.GetUnixFileMode(path);
        }
        public virtual UnixFileMode GetUnixFileMode(SafeFileHandle fileHandle) {
            return File.GetUnixFileMode(fileHandle);
        }

        public virtual IAsyncEnumerable<String> ReadLinesAsync(String path, CancellationToken cancellationToken) {
            return File.ReadLinesAsync(path, cancellationToken);
        }
        public virtual IAsyncEnumerable<String> ReadLinesAsync(String path, Encoding encoding, CancellationToken cancellationToken) {
            return File.ReadLinesAsync(path, encoding, cancellationToken);
        }
        public virtual void SetAttributes(SafeFileHandle fileHandle, FileAttributes fileAttributes) {
            File.SetAttributes(fileHandle, fileAttributes);
        }
        public virtual void SetCreationTime(SafeFileHandle fileHandle, DateTime creationTime) {
            File.SetCreationTime(fileHandle, creationTime);
        }
        public virtual void SetCreationTimeUtc(SafeFileHandle fileHandle, DateTime creationTimeUtc) {
            File.SetCreationTimeUtc(fileHandle, creationTimeUtc);
        }
        public virtual void SetLastAccessTime(SafeFileHandle fileHandle, DateTime lastAccessTime) {
            File.SetLastAccessTime(fileHandle, lastAccessTime);
        }
        public virtual void SetLastAccessTimeUtc(SafeFileHandle fileHandle, DateTime lastAccessTimeUtc) {
            File.SetLastAccessTimeUtc(fileHandle, lastAccessTimeUtc);
        }
        public virtual void SetLastWriteTime(SafeFileHandle fileHandle, DateTime lastWriteTime) {
            File.SetLastWriteTime(fileHandle, lastWriteTime);
        }
        public virtual void SetLastWriteTimeUtc(SafeFileHandle fileHandle, DateTime lastWriteTimeUtc) {
            File.SetLastWriteTimeUtc(fileHandle, lastWriteTimeUtc);
        }
        public virtual void SetUnixFileMode(String path, UnixFileMode mode) {
            File.SetUnixFileMode(path, mode);
        }
        public virtual void SetUnixFileMode(SafeFileHandle fileHandle, UnixFileMode mode) {
            File.SetUnixFileMode(fileHandle, mode);
        }
#endif
    }
}
