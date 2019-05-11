using System.IO;

namespace StaticAbstraction.IO
{
    public class StAbFileInfo : StAbFileSystemInfo, IFileInfo
    {
        protected FileInfo _fileInfoRef;

        public StAbFileInfo(string path) : base(new FileInfo(path))
        {
            SetFileInfo();
        }
        public StAbFileInfo(FileInfo file) : base(file)
        {
            SetFileInfo();
        }

        protected void SetFileInfo()
        {
            if (BaseInfo != null)
            {
                _fileInfoRef = (FileInfo) BaseInfo;
                if (_fileInfoRef.Directory != null) this.Directory = new StAbDirectoryInfo(_fileInfoRef.Directory);
            }
        }

        public IDirectoryInfo Directory { get; set; }

        public string DirectoryName => _fileInfoRef.DirectoryName;

        public long Length => _fileInfoRef.Length;

        public bool IsReadOnly
        {
            get => _fileInfoRef.IsReadOnly;
            set => _fileInfoRef.IsReadOnly = value;
        }

        public override bool Exists => _fileInfoRef.Exists;

        public override string Name => _fileInfoRef.Name;

        public StreamWriter AppendText()
        {
            return _fileInfoRef.AppendText();
        }

        public IFileInfo CopyTo(string destFileName)
        {
            return _fileInfoRef.CopyTo(destFileName).ToStaticAbstraction();
        }

        public IFileInfo CopyTo(string destFileName, bool overwrite)
        {
            return _fileInfoRef.CopyTo(destFileName, overwrite).ToStaticAbstraction();
        }

        public FileStream Create()
        {
            return _fileInfoRef.Create();
        }

        public StreamWriter CreateText()
        {
            return _fileInfoRef.CreateText();
        }

        public void Decrypt()
        {
            _fileInfoRef.Decrypt();
        }

        public void Encrypt()
        {
            _fileInfoRef.Encrypt();
        }

        public void MoveTo(string destFileName)
        {
            _fileInfoRef.MoveTo(destFileName);
        }
        public FileStream Open(FileMode mode)
        {
            return _fileInfoRef.Open(mode);
        }
        public FileStream OpenRead()
        {
            return _fileInfoRef.OpenRead();
        }
        public StreamReader OpenText()
        {
            return _fileInfoRef.OpenText();
        }
        public FileStream OpenWrite()
        {
            return _fileInfoRef.OpenWrite();
        }

        public IFileInfo Replace(string destinationFileName, string destinationBackupFileName)
        {
            return _fileInfoRef.Replace(destinationFileName, destinationBackupFileName).ToStaticAbstraction();
        }

        public IFileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            return _fileInfoRef.Replace(destinationFileName, destinationBackupFileName, ignoreMetadataErrors).ToStaticAbstraction();
        }

        public override void Delete()
        {
            _fileInfoRef.Delete();
        }
    }
}
