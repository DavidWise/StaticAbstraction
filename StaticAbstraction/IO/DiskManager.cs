namespace StaticAbstraction.IO
{
    public class DiskManager : IDiskManager
    {
        public IFile File { get; set; }
        public IPath Path { get; set; }
        public IDirectory Directory { get; set; }
        public IConsole Console { get; set; }

        public DiskManager()
        {
            this.File = new StAbFile();
            this.Path = new StAbPath();
            this.Directory = new StAbDirectory();
            this.Console = new StAbConsole();
        }

        public DiskManager(IFile file, IPath path, IDirectory directory, IConsole console)
        {
            this.File = file;
            this.Path = path;
            this.Directory = directory;
            this.Console = console;
        }

        public IFileInfo NewFileInfo(string path)
        {
            return new StAbFileInfo(path);
        }

        public IDirectoryInfo NewDirectoryInfo(string path)
        {
            return new StAbDirectoryInfo(path);
        }
    }
}
