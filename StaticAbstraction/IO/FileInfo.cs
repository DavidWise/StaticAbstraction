using System.IO;

namespace StaticAbstraction.IO
{
    public class StAbFileInfo : StAbFileSystemInfo, IFileInfo
    {
        protected new FileInfo WrappedObject { get; private set; }

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
            if (base.WrappedObject != null)
            {
                WrappedObject = (FileInfo) base.WrappedObject;
                if (WrappedObject.Directory != null) this.Directory = new StAbDirectoryInfo(WrappedObject.Directory);
            }
        }

        public virtual IDirectoryInfo Directory { get; set; }

        public virtual string DirectoryName => WrappedObject.DirectoryName;

        public virtual long Length => WrappedObject.Length;

        public virtual bool IsReadOnly
        {
            get => WrappedObject.IsReadOnly;
            set => WrappedObject.IsReadOnly = value;
        }

        public override bool Exists => WrappedObject.Exists;

        public override string Name => WrappedObject.Name;

        public virtual StreamWriter AppendText()
        {
            return WrappedObject.AppendText();
        }

        public virtual IFileInfo CopyTo(string destFileName)
        {
            return WrappedObject.CopyTo(destFileName).ToStaticAbstraction();
        }

        public virtual IFileInfo CopyTo(string destFileName, bool overwrite)
        {
            return WrappedObject.CopyTo(destFileName, overwrite).ToStaticAbstraction();
        }

        public virtual FileStream Create()
        {
            return WrappedObject.Create();
        }

        public virtual StreamWriter CreateText()
        {
            return WrappedObject.CreateText();
        }

        public virtual void Decrypt()
        {
            WrappedObject.Decrypt();
        }

        public virtual void Encrypt()
        {
            WrappedObject.Encrypt();
        }

        public virtual void MoveTo(string destFileName)
        {
            WrappedObject.MoveTo(destFileName);
        }

#if NETCORE30 || NETCORE31
        public virtual void MoveTo(string destFileName, bool overwrite)
        {
            WrappedObject.MoveTo(destFileName, overwrite);
        }
#endif
        public virtual FileStream Open(FileMode mode)
        {
            return WrappedObject.Open(mode);
        }
        public virtual FileStream OpenRead()
        {
            return WrappedObject.OpenRead();
        }
        public virtual StreamReader OpenText()
        {
            return WrappedObject.OpenText();
        }
        public virtual FileStream OpenWrite()
        {
            return WrappedObject.OpenWrite();
        }

        public virtual IFileInfo Replace(string destinationFileName, string destinationBackupFileName)
        {
            return WrappedObject.Replace(destinationFileName, destinationBackupFileName).ToStaticAbstraction();
        }

        public virtual IFileInfo Replace(string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            return WrappedObject.Replace(destinationFileName, destinationBackupFileName, ignoreMetadataErrors).ToStaticAbstraction();
        }

        public override void Delete()
        {
            WrappedObject.Delete();
        }
    }
}
