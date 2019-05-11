using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StaticAbstraction.IO.Mocks
{
    public class MockDriveInfoDetails :IDriveInfoDetails
    {
        public long AvailableFreeSpace { get; set; }
        public string DriveFormat { get; set; }
        public DriveType DriveType { get; set; }
        public bool IsReady { get; set; }
        public string Name { get; set; }
        public IDirectoryInfo RootDirectory { get; set; }
        public long TotalFreeSpace { get; set; }
        public long TotalSize { get; set; }
        public string VolumeLabel { get; set; }
    }
}
