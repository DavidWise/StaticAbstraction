using System.IO;

namespace StaticAbstraction.IO
{
    public class StAbDriveInfoDetails : IDriveInfoDetails
    {
        protected DriveInfo WrappedObject { get; private set; }

        public virtual long AvailableFreeSpace
        {
            get { return WrappedObject.AvailableFreeSpace;  }
        }
        public virtual string DriveFormat
        {
            get { return WrappedObject.DriveFormat; }
        }
        public virtual DriveType DriveType
        {
            get { return WrappedObject.DriveType; }
        }
        public virtual bool IsReady
        {
            get { return WrappedObject.IsReady; }
        }
        public virtual string Name
        {
            get { return WrappedObject.Name; }
        }

        public virtual IDirectoryInfo RootDirectory
        {
            get { return WrappedObject.RootDirectory.ToStaticAbstraction(); }
        }

        public virtual long TotalFreeSpace
        {
            get { return WrappedObject.TotalFreeSpace; }
        }

        public virtual long TotalSize
        {
            get { return WrappedObject.TotalSize; }
        }

        public virtual string VolumeLabel
        {
            get { return WrappedObject.VolumeLabel; }
            set { WrappedObject.VolumeLabel = value; }
        }

        public StAbDriveInfoDetails(DriveInfo info)
        {
            WrappedObject = info;
        }
    }
}
