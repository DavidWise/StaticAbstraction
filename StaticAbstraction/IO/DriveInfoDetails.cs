using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace StaticAbstraction.IO
{
    public class StAbDriveInfoDetails : IDriveInfoDetails
    {
        protected DriveInfo _info;

        public long AvailableFreeSpace
        {
            get { return _info.AvailableFreeSpace;  }
        }
        public string DriveFormat
        {
            get { return _info.DriveFormat; }
        }
        public DriveType DriveType
        {
            get { return _info.DriveType; }
        }
        public bool IsReady
        {
            get { return _info.IsReady; }
        }
        public string Name
        {
            get { return _info.Name; }
        }

        public IDirectoryInfo RootDirectory
        {
            get { return _info.RootDirectory.ToStaticAbstraction(); }
        }

        public long TotalFreeSpace
        {
            get { return _info.TotalFreeSpace; }
        }

        public long TotalSize
        {
            get { return _info.TotalSize; }
        }

        public string VolumeLabel
        {
            get { return _info.VolumeLabel; }
            set { _info.VolumeLabel = value; }
        }

        public StAbDriveInfoDetails(DriveInfo info)
        {
            _info = info;
        }
    }
}
