using System.Collections.Generic;
using System.IO;

namespace StaticAbstraction.IO
{
    public class StAbDirectoryInfo : StAbFileSystemInfo, IDirectoryInfo
    {
        private DirectoryInfo _info = null;
        private IDirectoryInfo _parent = null;
        private IDirectoryInfo _root = null;

        public IDirectoryInfo Parent
        {
            get
            {
                if (_parent == null && _info != null && _info.Parent != null)
                {
                    _parent = _info.Parent.ToStaticAbstraction();
                }
                return _parent;
            }
        }

        public IDirectoryInfo Root
        {
            get
            {
                if (_root == null && _info != null && _info.Root != null)
                {
                    _root = _info.Root.ToStaticAbstraction();
                }
                return _root;
            }
        }


        public override bool Exists => _info.Exists;

        public override string Name => _info.Name;

        public StAbDirectoryInfo(string path) : base(new DirectoryInfo(path))
        {
            Init();
        }

        public StAbDirectoryInfo(DirectoryInfo info) : base(info)
        {
            Init();
        }

        protected void Init()
        {
            if (BaseInfo != null)
            {
                _info = (DirectoryInfo)this.BaseInfo;
            }
        }



        public void Create()
        {
            _info.Create();
        }

        public IDirectoryInfo CreateSubdirectory(string path)
        {
            return _info.CreateSubdirectory(path).ToStaticAbstraction();
        }
        public override void Delete()
        {
            _info.Delete();
        }
        public IEnumerable<IDirectoryInfo> EnumerateDirectories()
        {
            return _info.EnumerateDirectories().ToStaticAbstraction();
        }

        public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern)
        {
            return _info.EnumerateDirectories(searchPattern).ToStaticAbstraction();
        }
        public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption)
        {
            return _info.EnumerateDirectories(searchPattern, searchOption).ToStaticAbstraction();
        }

        public IEnumerable<IFileInfo> EnumerateFiles()
        {
            return _info.EnumerateFiles().ToStaticAbstraction();
        }
        public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern)
        {
            return _info.EnumerateFiles(searchPattern).ToStaticAbstraction();
        }



        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern)
        {
            return _info.EnumerateFileSystemInfos(searchPattern).ToStaticAbstraction();
        }

        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
            return _info.EnumerateFileSystemInfos(searchPattern, searchOption).ToStaticAbstraction();
        }

        public IDirectoryInfo[] GetDirectories()
        {
            return _info.GetDirectories().ToStaticAbstraction();
        }
        public IDirectoryInfo[] GetDirectories(string searchPattern)
        {
            return _info.GetDirectories(searchPattern).ToStaticAbstraction();
        }

        public IDirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption)
        {
            return _info.GetDirectories(searchPattern, searchOption).ToStaticAbstraction();
        }

        public IFileInfo[] GetFiles()
        {
            return _info.GetFiles().ToStaticAbstraction();
        }
        public IFileInfo[] GetFiles(string mask)
        {
            return _info.GetFiles(mask).ToStaticAbstraction();
        }
        public IFileInfo[] GetFiles(string mask, SearchOption searchOption)
        {
            return _info.GetFiles(mask, searchOption).ToStaticAbstraction();
        }

        public IFileSystemInfo[] GetFileSystemInfos()
        {
            return _info.GetFileSystemInfos().ToStaticAbstraction();
        }
        public IFileSystemInfo[] GetFileSystemInfos(string searchPattern)
        {
            return _info.GetFileSystemInfos(searchPattern).ToStaticAbstraction();
        }
        public IFileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption)
        {
            return _info.GetFileSystemInfos(searchPattern, searchOption).ToStaticAbstraction();
        }


        public void MoveTo(string destDirName)
        {
            _info.MoveTo(destDirName);
        }

#if NETCORE22
        public IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, EnumerationOptions enumerationOptions)
        {
            return _info.EnumerateDirectories(searchPattern, enumerationOptions).ToStaticAbstraction();
        }
        public IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, EnumerationOptions enumerationOptions)
        {
            return _info.EnumerateFiles(searchPattern, enumerationOptions).ToStaticAbstraction();
        }
        public IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions)
        {
            return _info.EnumerateFileSystemInfos(searchPattern, enumerationOptions).ToStaticAbstraction();
        }
        public IDirectoryInfo[] GetDirectories(string searchPattern, EnumerationOptions enumerationOptions)
        {
            return _info.GetDirectories(searchPattern, enumerationOptions).ToStaticAbstraction();
        }
        public IFileSystemInfo[] GetFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions)
        {
            return _info.GetFileSystemInfos(searchPattern, enumerationOptions).ToStaticAbstraction();
        }

#endif
    }
}
