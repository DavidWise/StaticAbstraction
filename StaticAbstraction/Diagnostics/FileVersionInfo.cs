using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace StaticAbstraction.Diagnostics
{
    public interface IFileVersionInfo
    {
        IFileVersionInfoInstance GetVersionInfo(string fileName);
    }

    public class StAbFileVersionInfo : IFileVersionInfo
    {
        public virtual IFileVersionInfoInstance GetVersionInfo(string fileName)
        {
            var info = FileVersionInfo.GetVersionInfo(fileName);
            return new StAbFileVersionInfoInstance(info);
        }
    }
}
