using System.IO;

namespace StaticAbstraction.IO
{
    public class StAbDriveInfo : IDriveInfo
    {
        public virtual IDriveInfoDetails[] GetDrives()
        {
            return DriveInfo.GetDrives().ToStaticAbstraction();
        }
    }
}
