using System.IO;

namespace StaticAbstraction.IO.Mocks
{
    public class MockFileInfo : MockFileSystemInfo, IFileInfo
    {
        public virtual IDirectoryInfo Directory { get; set; }
        public virtual string DirectoryName { get; set; }
        public virtual long Length { get; set; }
        public virtual bool IsReadOnly { get; set; }

        public virtual StreamWriter AppendText()
        {
            return null;
        }

        public virtual IFileInfo CopyTo(string destFileName)
        {
            return null;
        }

        public virtual IFileInfo CopyTo(string destFileName, bool overwrite)
        {
            return null;
        }

        public virtual FileStream Create()
        {
            return null;
        }

        public virtual StreamWriter CreateText()
        {
            return null;
        }

        public virtual void Decrypt()
        {
        }

        public virtual void Encrypt()
        {
        }


        public virtual void MoveTo(string destFileName)
        {
        }

#if NETCOREAPP3_0_OR_GREATER
        public void MoveTo(string destFileName, bool overwrite)
        {
        }
#endif

        public virtual FileStream Open(FileMode mode)
        {
            return null;
        }

#if NET6_0_OR_GREATER
        public virtual FileStream Open(FileStreamOptions options)
        {
            return null;
        }
#endif
        public virtual FileStream OpenRead()
        {
            return null;
        }

        public virtual StreamReader OpenText()
        {
            return null;
        }

        public virtual FileStream OpenWrite()
        {
            return null;
        }

        public virtual IFileInfo Replace(string destinationFileName, string destinationBackupFileName)
        {
            return null;
        }

        public virtual IFileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            return null;
        }
    }
}