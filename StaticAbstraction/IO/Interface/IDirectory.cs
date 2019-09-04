using System;
using System.Collections.Generic;
using System.IO;

namespace StaticAbstraction.IO
{
    public interface IDirectory
    {
        IDirectoryInfo CreateDirectory(string path);
        void Delete(string path);

        IEnumerable<string> EnumerateDirectories(string path);
        IEnumerable<string> EnumerateDirectories(string path, string searchPattern);
        IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption);

        IEnumerable<string> EnumerateFiles(string path);
        IEnumerable<string> EnumerateFiles(string path, string searchPattern);
        
        IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption);

        IEnumerable<string> EnumerateFileSystemEntries(string path);
        IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern);
        
        IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption);

        bool Exists(string path);

        DateTime GetCreationTime(string path);
        DateTime GetCreationTimeUtc(string path);

        string GetCurrentDirectory();

        string[] GetDirectories(string path);
        string[] GetDirectories(string path, string searchPattern);
        
        string[] GetDirectories(string path, string searchPattern, SearchOption searchOption);

        string GetDirectoryRoot(string path);

        string[] GetFiles(string path);
        string[] GetFiles(string path, string searchPattern);
        
        string[] GetFiles(string path, string searchPattern, SearchOption searchOption);

        string[] GetFileSystemEntries(string path);
        string[] GetFileSystemEntries(string path, string searchPattern);
        
        string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption);

        DateTime GetLastAccessTime(string path);
        DateTime GetLastAccessTimeUtc(string path);

        DateTime GetLastWriteTime(string path);
        DateTime GetLastWriteTimeUtc(string path);

        string[] GetLogicalDrives();
        IDirectoryInfo GetParent(string path);

        void Move(string sourceDirName, string destDirName);

        void SetCreationTime(string path, DateTime creationTime);
        void SetCreationTimeUtc(string path, DateTime creationTimeUtc);
        void SetLastAccessTime(string path, DateTime lastAccessTime);
        void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc);
        void SetLastWriteTime(string path, DateTime lastWriteTime);
        void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc);

        void SetCurrentDirectory(string path);

#if NETCORE22 || NETCORE30
        IEnumerable<string> EnumerateDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions);
        IEnumerable<string> EnumerateFiles(string path, string searchPattern, EnumerationOptions enumerationOptions);
        IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions);
        string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions);
        string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions);
        string[] GetFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions);
#endif
    }
}
