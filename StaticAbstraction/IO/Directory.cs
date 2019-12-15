using System;
using System.Collections.Generic;
using System.IO;

namespace StaticAbstraction.IO
{
    public class StAbDirectory : IDirectory
    {
        public virtual IDirectoryInfo CreateDirectory(string path)
        {
            return Directory.CreateDirectory(path).ToStaticAbstraction();

        }
        public virtual void Delete(string path)
        {
            Directory.Delete(path);
        }
        public virtual void Delete(string path, bool recursive)
        {
            Directory.Delete(path, recursive);
        }


        public virtual IEnumerable<string> EnumerateDirectories(string path)
        {
            return Directory.EnumerateDirectories(path);
        }
        public virtual IEnumerable<string> EnumerateDirectories(string path, string searchPattern)
        {
            return Directory.EnumerateDirectories(path, searchPattern);
        }
        public virtual IEnumerable<string> EnumerateDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.EnumerateDirectories(path, searchPattern, searchOption);
        }


        public virtual IEnumerable<string> EnumerateFiles(string path)
        {
            return Directory.EnumerateFiles(path);
        }
        public virtual IEnumerable<string> EnumerateFiles(string path, string searchPattern)
        {
            return Directory.EnumerateFiles(path, searchPattern);
        }
        public virtual IEnumerable<string> EnumerateFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.EnumerateFiles(path, searchPattern, searchOption);
        }


        public virtual IEnumerable<string> EnumerateFileSystemEntries(string path)
        {
            return Directory.EnumerateFileSystemEntries(path);
        }
        public virtual IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern)
        {
            return Directory.EnumerateFileSystemEntries(path, searchPattern);
        }

        public virtual IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.EnumerateFileSystemEntries(path, searchPattern, searchOption);
        }

        public virtual bool Exists(string path)
        {
            return Directory.Exists(path);
        }

        public virtual DateTime GetCreationTime(string path)
        {
            return Directory.GetCreationTime(path);
        }
        public virtual DateTime GetCreationTimeUtc(string path)
        {
            return Directory.GetCreationTimeUtc(path);
        }


        public virtual string GetCurrentDirectory()
        {
            return Directory.GetCurrentDirectory();
        }

        
        public virtual string[] GetDirectories(string path)
        {
            return Directory.GetDirectories(path);
        }
        public virtual string[] GetDirectories(string path, string searchPattern)
        {
            return Directory.GetDirectories(path, searchPattern);
        }

        public virtual string[] GetDirectories(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.GetDirectories(path, searchPattern, searchOption);
        }

        public virtual string GetDirectoryRoot(string path)
        {
            return Directory.GetDirectoryRoot(path);
        }

        public virtual string[] GetFiles(string path)
        {
            return Directory.GetFiles(path);
        }
        public virtual string[] GetFiles(string path, string searchPattern)
        {
            return Directory.GetFiles(path, searchPattern);
        }

        public virtual string[] GetFiles(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.GetFiles(path, searchPattern, searchOption);
        }


        public virtual string[] GetFileSystemEntries(string path)
        {
            return Directory.GetFileSystemEntries(path);
        }
        public virtual string[] GetFileSystemEntries(string path, string searchPattern)
        {
            return Directory.GetFileSystemEntries(path, searchPattern);
        }

        public virtual string[] GetFileSystemEntries(string path, string searchPattern, SearchOption searchOption)
        {
            return Directory.GetFileSystemEntries(path, searchPattern, searchOption);
        }

        public virtual DateTime GetLastAccessTime(string path)
        {
            return Directory.GetLastAccessTime(path);
        }
        public virtual DateTime GetLastAccessTimeUtc(string path)
        {
            return Directory.GetLastAccessTimeUtc(path);
        }

        public virtual DateTime GetLastWriteTime(string path)
        {
            return Directory.GetLastWriteTime(path);
        }
        public virtual DateTime GetLastWriteTimeUtc(string path)
        {
            return Directory.GetLastWriteTimeUtc(path);
        }

        public virtual string[] GetLogicalDrives()
        {
            return Directory.GetLogicalDrives();
        }

        public virtual IDirectoryInfo GetParent(string path)
        {
            return Directory.GetParent(path).ToStaticAbstraction();
        }

        public virtual void Move(string sourceDirName, string destDirName)
        {
            Directory.Move(sourceDirName, destDirName);
        }

        public virtual void SetCreationTime(string path, DateTime creationTime)
        {
            Directory.SetCreationTime(path, creationTime);
        }
        public virtual void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
        {
            Directory.SetCreationTimeUtc(path, creationTimeUtc);
        }

        public virtual void SetLastAccessTime(string path, DateTime lastAccessTime)
        {
            Directory.SetLastAccessTime(path, lastAccessTime);
        }
        public virtual void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        {
            Directory.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
        }

        public virtual void SetLastWriteTime(string path, DateTime lastWriteTime)
        {
            Directory.SetLastWriteTime(path, lastWriteTime);
        }
        public virtual void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        {
            Directory.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
        }

        public virtual void SetCurrentDirectory(string path)
        {
            Directory.SetCurrentDirectory(path);
        }

#if NETSTANDARD2_1 || NETCORE21 || NETCORE22
        public virtual IEnumerable<string> EnumerateDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions)
        {
            return Directory.EnumerateDirectories(path, searchPattern, enumerationOptions);
        }

        public virtual IEnumerable<string> EnumerateFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
        {
            return Directory.EnumerateFiles(path, searchPattern, enumerationOptions);
        }

        public virtual IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions)
        {
            return Directory.EnumerateFileSystemEntries(path, searchPattern, enumerationOptions);
        }
        public virtual string[] GetDirectories(string path, string searchPattern, EnumerationOptions enumerationOptions)
        {
            return Directory.GetDirectories(path, searchPattern, enumerationOptions);
        }
        public virtual string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions)
        {
            return Directory.GetFiles(path, searchPattern, enumerationOptions);
        }
        public virtual string[] GetFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions)
        {
            return Directory.GetFileSystemEntries(path, searchPattern, enumerationOptions);
        }
#endif

    }
}
