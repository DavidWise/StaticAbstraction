using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using StaticAbstraction.Diagnostics.Interface;

namespace StaticAbstraction.Diagnostics
{

#if NET40_OR_GREATER || NETCOREAPP3_0_OR_GREATER

    public class StAbFileVersionInfo : IFileVersionInfo
    {
        public virtual IFileVersionInfoInstance GetVersionInfo(string fileName)
        {
            var info = FileVersionInfo.GetVersionInfo(fileName);
            return new StAbFileVersionInfoInstance(info);
        }
    }
#endif
}
