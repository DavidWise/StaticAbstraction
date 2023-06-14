using System.Collections.Generic;
using System.IO;

namespace StaticAbstraction.IO
{
    public class StAbDirectoryInfo : StAbFileSystemInfo, IDirectoryInfo
    {
        protected new DirectoryInfo WrappedObject { get; private set; }
        private IDirectoryInfo _parent = null;
        private IDirectoryInfo _root = null;

        public virtual IDirectoryInfo Parent
        {
            get
            {
                if (_parent == null && WrappedObject != null && WrappedObject.Parent != null)
                {
                    _parent = WrappedObject.Parent.ToStaticAbstraction();
                }
                return _parent;
            }
        }

        public virtual IDirectoryInfo Root
        {
            get
            {
                if (_root == null && WrappedObject != null && WrappedObject.Root != null)
                {
                    _root = WrappedObject.Root.ToStaticAbstraction();
                }
                return _root;
            }
        }


        public override bool Exists => WrappedObject.Exists;

        public override string Name => WrappedObject.Name;

        public StAbDirectoryInfo(string path) : base(new DirectoryInfo(path))
        {
            InitDirectoryInfo();
        }

        public StAbDirectoryInfo(DirectoryInfo info) : base(info)
        {
            InitDirectoryInfo();
        }

        private void InitDirectoryInfo()
        {
            if (base.WrappedObject != null)
            {
                WrappedObject = (DirectoryInfo)base.WrappedObject;
            }
        }


        public virtual void Create()
        {
            WrappedObject.Create();
        }

        public virtual IDirectoryInfo CreateSubdirectory(string path)
        {
            return WrappedObject.CreateSubdirectory(path).ToStaticAbstraction();
        }
        public override void Delete()
        {
            WrappedObject.Delete();
        }
        public virtual IEnumerable<IDirectoryInfo> EnumerateDirectories()
        {
            return WrappedObject.EnumerateDirectories().ToStaticAbstraction();
        }

        public virtual IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern)
        {
            return WrappedObject.EnumerateDirectories(searchPattern).ToStaticAbstraction();
        }
        public virtual IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
        {
            return WrappedObject.EnumerateDirectories(searchPattern, searchOption).ToStaticAbstraction();
        }

        public virtual IEnumerable<IFileInfo> EnumerateFiles()
        {
            return WrappedObject.EnumerateFiles().ToStaticAbstraction();
        }
        public virtual IEnumerable<IFileInfo> EnumerateFiles(string searchPattern)
        {
            return WrappedObject.EnumerateFiles(searchPattern).ToStaticAbstraction();
        }



        public virtual IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
        {
            return WrappedObject.EnumerateFileSystemInfos(searchPattern).ToStaticAbstraction();
        }

        public virtual IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
            return WrappedObject.EnumerateFileSystemInfos(searchPattern, searchOption).ToStaticAbstraction();
        }

        public virtual IDirectoryInfo[] GetDirectories()
        {
            return WrappedObject.GetDirectories().ToStaticAbstraction();
        }
        public virtual IDirectoryInfo[] GetDirectories(string searchPattern)
        {
            return WrappedObject.GetDirectories(searchPattern).ToStaticAbstraction();
        }

        public virtual IDirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
        {
            return WrappedObject.GetDirectories(searchPattern, searchOption).ToStaticAbstraction();
        }

        public virtual IFileInfo[] GetFiles()
        {
            return WrappedObject.GetFiles().ToStaticAbstraction();
        }
        public virtual IFileInfo[] GetFiles(string mask)
        {
            return WrappedObject.GetFiles(mask).ToStaticAbstraction();
        }
        public virtual IFileInfo[] GetFiles(string mask, SearchOption searchOption)
        {
            return WrappedObject.GetFiles(mask, searchOption).ToStaticAbstraction();
        }

#if NETCORE30 || NETCORE31 || NETCORE50 || NETCORE60
        public virtual IFileInfo[] GetFiles(string searchPattern, EnumerationOptions enumerationOptions)
        {
            return WrappedObject.GetFiles(searchPattern, enumerationOptions).ToStaticAbstraction();
        }
#endif

        public virtual IFileSystemInfo[] GetFileSystemInfos()
        {
            return WrappedObject.GetFileSystemInfos().ToStaticAbstraction();
        }
        public virtual IFileSystemInfo[] GetFileSystemInfos(string searchPattern)
        {
            return WrappedObject.GetFileSystemInfos(searchPattern).ToStaticAbstraction();
        }
        public virtual IFileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
            return WrappedObject.GetFileSystemInfos(searchPattern, searchOption).ToStaticAbstraction();
        }


        public virtual void MoveTo(string destDirName)
        {
            WrappedObject.MoveTo(destDirName);
        }

#if NETSTANDARD2_1 || NETCORE21 || NETCORE22
        public virtual IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, EnumerationOptions enumerationOptions)
        {
            return WrappedObject.EnumerateDirectories(searchPattern, enumerationOptions).ToStaticAbstraction();
        }
        public virtual IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, EnumerationOptions enumerationOptions)
        {
            return WrappedObject.EnumerateFiles(searchPattern, enumerationOptions).ToStaticAbstraction();
        }
        public virtual IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions)
        {
            return WrappedObject.EnumerateFileSystemInfos(searchPattern, enumerationOptions).ToStaticAbstraction();
        }
        public virtual IDirectoryInfo[] GetDirectories(string searchPattern, EnumerationOptions enumerationOptions)
        {
            return WrappedObject.GetDirectories(searchPattern, enumerationOptions).ToStaticAbstraction();
        }
        public virtual IFileSystemInfo[] GetFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions)
        {
            return WrappedObject.GetFileSystemInfos(searchPattern, enumerationOptions).ToStaticAbstraction();
        }

#endif
    }
}
