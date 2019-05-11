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
