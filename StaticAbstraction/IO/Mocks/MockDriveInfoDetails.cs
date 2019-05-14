using System.IO;

namespace StaticAbstraction.IO.Mocks
{
    public class MockDriveInfoDetails :IDriveInfoDetails
    {
        public virtual long AvailableFreeSpace { get; set; }
        public virtual string DriveFormat { get; set; }
        public virtual DriveType DriveType { get; set; }
        public virtual bool IsReady { get; set; }
        public virtual string Name { get; set; }
        public virtual IDirectoryInfo RootDirectory { get; set; }
        public virtual long TotalFreeSpace { get; set; }
        public virtual long TotalSize { get; set; }
        public virtual string VolumeLabel { get; set; }
    }
}
