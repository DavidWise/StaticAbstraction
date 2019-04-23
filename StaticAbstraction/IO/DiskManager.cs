namespace StaticAbstraction.IO
{


    public class DiskManager : IDiskManager
    {
        private static DiskManager _current;

        public IFile File { get; set; }
        public IPath Path { get; set; }
        public IDirectory Directory { get; set; }

        public DiskManager()
        {
            this.File = new StAbFile();
            this.Path = new StAbPath();
            this.Directory = new StAbDirectory();
        }

        public DiskManager(IFile file, IPath path, IDirectory directory)
        {
            this.File = file;
            this.Path = path;
            this.Directory = directory;
        }

        public IFileInfo GetFileInfo(string path)
        {
            return new StAbFileInfo(path);
        }

        public IDirectoryInfo GetDirectoryInfo(string path)
        {
            return new StAbDirectoryInfo(path);
        }


        public static DiskManager Current
        {
            get
            {
                if (_current == null) _current = new DiskManager();
                return _current;
            }
        }
    }
}
