using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace StaticAbstraction.IO
{
    public class StAbDriveInfo : IDriveInfo
    {
        public IDriveInfoDetails[] GetDrives()
        {
            return DriveInfo.GetDrives().ToStaticAbstraction();
        }
    }
}
