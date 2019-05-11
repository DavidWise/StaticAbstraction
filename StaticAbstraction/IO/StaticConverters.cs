using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StaticAbstraction.IO
{
    public static class StaticConverters
    {
        public static IFileInfo ToStaticAbstraction(this FileInfo info)
        {
            IFileInfo result = null;
            if (info != null) result = new StAbFileInfo(info);
            return result;
        }


        public static IDirectoryInfo ToStaticAbstraction(this DirectoryInfo info)
        {
            IDirectoryInfo result = null;
            if (info != null) result = new StAbDirectoryInfo(info);
            return result;
        }

        public static IFileSystemInfo ToStaticAbstraction(this FileSystemInfo info)
        {
            IFileSystemInfo result = null;
            if (info != null)
            {
                if (info is FileInfo) result = new StAbFileInfo((FileInfo)info);
                if (info is DirectoryInfo) result = new StAbDirectoryInfo((DirectoryInfo)info);
            }
            return result;
        }

        public static IDriveInfoDetails ToStaticAbstraction(this DriveInfo info)
        {
            IDriveInfoDetails result = null;
            if (info != null) result = new StAbDriveInfoDetails(info);
            return result;
        }

        public static IFileInfo[] ToStaticAbstraction(this FileInfo[] items)
        {
            if (items == null) return null;

            var len = items.Length;
            var result = new IFileInfo[len];

            if (len > 0)
            {
                for (var  i=0; i<len; i++)
                {
                    result[i] = items[i].ToStaticAbstraction();
                }
            }

            return result;
        }

        public static IDirectoryInfo[] ToStaticAbstraction(this DirectoryInfo[] items)
        {
            if (items == null) return null;

            var len = items.Length;
            var result = new IDirectoryInfo[len];

            if (len > 0)
            {
                for (var i = 0; i < len; i++)
                {
                    result[i] = items[i].ToStaticAbstraction();
                }
            }

            return result;
        }

        public static IFileSystemInfo[] ToStaticAbstraction(this FileSystemInfo[] items)
        {
            if (items == null) return null;

            var len = items.Length;
            var result = new IFileSystemInfo[len];

            if (len > 0)
            {
                for (var i = 0; i < len; i++)
                {
                    result[i] = items[i].ToStaticAbstraction();
                }
            }

            return result;
        }

        public static IDriveInfoDetails[] ToStaticAbstraction(this DriveInfo[] items)
        {
            if (items == null) return null;

            var len = items.Length;
            var result = new IDriveInfoDetails[len];

            if (len > 0)
            {
                for (var i = 0; i < len; i++)
                {
                    result[i] = items[i].ToStaticAbstraction();
                }
            }

            return result;
        }

        public static IEnumerable<IDirectoryInfo> ToStaticAbstraction(this IEnumerable<DirectoryInfo> items)
        {
            if (items == null) return null;
            var result = new List<IDirectoryInfo>();

            foreach(var item in items)
            {
                result.Add(item.ToStaticAbstraction());
            }
            return result;
        }

        public static IEnumerable<IFileInfo> ToStaticAbstraction(this IEnumerable<FileInfo> items)
        {
            if (items == null) return null;
            var result = new List<IFileInfo>();

            foreach (var item in items)
            {
                result.Add(item.ToStaticAbstraction());
            }
            return result;
        }


        public static IEnumerable<IFileSystemInfo> ToStaticAbstraction(this IEnumerable<FileSystemInfo> items)
        {
            if (items == null) return null;
            var result = new List<IFileSystemInfo>();

            foreach (var item in items)
            {
                result.Add(item.ToStaticAbstraction());
            }
            return result;
        }

    }
}
