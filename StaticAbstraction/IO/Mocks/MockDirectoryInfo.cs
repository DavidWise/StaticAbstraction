using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using StaticAbstraction.IO;

namespace StaticAbstraction.IO.Mocks
{
    public class MockDirectoryInfo : MockFileSystemInfo, IDirectoryInfo
    {
        public virtual IDirectoryInfo Parent { get; set; }

        public virtual IDirectoryInfo Root { get; set; }

        public virtual void Create()
        {
        }

        public virtual IDirectoryInfo CreateSubdirectory(string path)
        {
            return null;
        }

        public virtual IEnumerable<IDirectoryInfo> EnumerateDirectories()
        {
            return null;
        }

        public virtual IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern)
        {
            return null;
        }

        public virtual IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, EnumerationOptions enumerationOptions)
        {
            return null;
        }

        public virtual IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
        {
            return null;
        }

        public virtual IEnumerable<IFileInfo> EnumerateFiles()
        {
            return null;
        }

        public virtual IEnumerable<IFileInfo> EnumerateFiles(string searchPattern)
        {
            return null;
        }

        public virtual IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, EnumerationOptions enumerationOptions)
        {
            return null;
        }

        public virtual IDirectoryInfo[] GetDirectories()
        {
            return null;
        }

        public virtual IDirectoryInfo[] GetDirectories(string searchPattern)
        {
            return null;
        }

        public virtual IDirectoryInfo[] GetDirectories(string searchPattern, EnumerationOptions enumerationOptions)
        {
            return null;
        }

        public virtual IDirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
        {
            return null;
        }

        public virtual IFileInfo[] GetFiles()
        {
            return null;
        }
        public virtual IFileInfo[] GetFiles(string mask)
        {
            return null;
        }
        public virtual IFileInfo[] GetFiles(string mask, SearchOption searchOption)
        {
            return null;
        }

        public virtual IFileSystemInfo[] GetFileSystemInfos()
        {
            return null;
        }

        public virtual IFileSystemInfo[] GetFileSystemInfos(string searchPattern)
        {
            return null;
        }

        public virtual IFileSystemInfo[] GetFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions)
        {
            return null;
        }

        public virtual IFileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
            return null;
        }

        public virtual void MoveTo(string destDirName)
        {
        }

    }
}
