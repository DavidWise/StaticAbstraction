namespace StaticAbstraction.IO
{
    /// This whole file exists so that unit tests can be run without needing to have existing files in place

    public interface IDiskManager
    {
        IFile File { get; set; }
        IPath Path { get; set; }
        IDirectory Directory { get; set; }
        IConsole Console { get; set; }

        IFileInfo NewFileInfo(string path);
        IDirectoryInfo NewDirectoryInfo(string path);

    }
}
