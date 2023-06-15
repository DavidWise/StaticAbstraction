using System.IO;

namespace StaticAbstraction.IO
{
    public interface IFileInfo : IFileSystemInfo
    {
        string DirectoryName { get; }
        long Length { get; }
        IDirectoryInfo Directory { get; }
        bool IsReadOnly { get; set; }

        StreamWriter AppendText();
        IFileInfo CopyTo(string destFileName);
        IFileInfo CopyTo(string destFileName, bool overwrite);
        FileStream Create();
        StreamWriter CreateText();
        void Decrypt();
        void Encrypt();
        void MoveTo(string destFileName);
#if NETCORE30 || NETCORE31 || NETCORE50 || NETCORE60
        void MoveTo(string destFileName, bool overwrite);
#endif
        FileStream Open(FileMode mode);

#if NETCORE60
        FileStream Open(FileStreamOptions options);
#endif
        FileStream OpenRead();
        StreamReader OpenText();
        FileStream OpenWrite();
        IFileInfo Replace(string destinationFileName, string destinationBackupFileName);
        IFileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors);

    }
}
