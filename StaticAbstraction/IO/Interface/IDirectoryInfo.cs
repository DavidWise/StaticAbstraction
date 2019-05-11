using System.Collections.Generic;
using System.IO;

namespace StaticAbstraction.IO
{
    public interface IDirectoryInfo : IFileSystemInfo
    {

        IDirectoryInfo Parent { get; }
        IDirectoryInfo Root { get; }

        void Create();
        IDirectoryInfo CreateSubdirectory(string path);

        IEnumerable<IDirectoryInfo> EnumerateDirectories();
        IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern);
        IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption);

        IEnumerable<IFileInfo> EnumerateFiles();
        IEnumerable<IFileInfo> EnumerateFiles(string searchPattern);

        IDirectoryInfo[] GetDirectories();
        IDirectoryInfo[] GetDirectories(string searchPattern);
        IDirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption);

        IFileInfo[] GetFiles();
        IFileInfo[] GetFiles(string mask);
        IFileInfo[] GetFiles(string mask, SearchOption searchOption);

        IFileSystemInfo[] GetFileSystemInfos();
        IFileSystemInfo[] GetFileSystemInfos(string searchPattern);
        IFileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption);

        void MoveTo(string destDirName);

#if NETCORE22
        IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, EnumerationOptions enumerationOptions);
        IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, EnumerationOptions enumerationOptions);
        IDirectoryInfo[] GetDirectories(string searchPattern, EnumerationOptions enumerationOptions);
        IFileSystemInfo[] GetFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions);

#endif
    }
}
