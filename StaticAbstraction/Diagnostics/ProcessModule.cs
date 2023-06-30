using StaticAbstraction.Diagnostics.Interface;
using System;
using System.Diagnostics;


namespace StaticAbstraction.Diagnostics
{


    public class StAbProcessModule : IProcessModule
    {
        public virtual IntPtr BaseAddress { get; protected set; }

        public virtual IntPtr EntryPointAddress { get; protected set; }

        public virtual string FileName { get; protected set; }

#if NET40_OR_GREATER || NETCOREAPP3_0_OR_GREATER
        public virtual IFileVersionInfoInstance FileVersionInfo { get; protected set; }
#endif

        public virtual int ModuleMemorySize { get; protected set; }

        public virtual string ModuleName { get; protected set; }

        public StAbProcessModule(ProcessModule module)
        {
            this.BaseAddress = module.BaseAddress;
            this.EntryPointAddress = module.EntryPointAddress;
            this.FileName = module.FileName;

#if NET40_OR_GREATER || NETCOREAPP3_0_OR_GREATER
            this.FileVersionInfo = new StAbFileVersionInfoInstance(module.FileVersionInfo);
#endif

            this.ModuleMemorySize = module.ModuleMemorySize;
            this.ModuleName = module.ModuleName;
        }
    }
}
