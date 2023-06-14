using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace StaticAbstraction.Diagnostics
{
    public interface IProcessModule
    {
        //
        // Summary:
        //     Gets the memory address where the module was loaded.
        //
        // Returns:
        //     The load address of the module.
        IntPtr BaseAddress { get; }
        //
        // Summary:
        //     Gets the memory address for the function that runs when the system loads and
        //     runs the module.
        //
        // Returns:
        //     The entry point of the module.
        IntPtr EntryPointAddress { get; }
        //
        // Summary:
        //     Gets the full path to the module.
        //
        // Returns:
        //     The fully qualified path that defines the location of the module.
        string FileName { get; }
        //
        // Summary:
        //     Gets version information about the module.
        //
        // Returns:
        //     A System.Diagnostics.FileVersionInfo that contains the module's version information.
        IFileVersionInfoInstance FileVersionInfo { get; }
        //
        // Summary:
        //     Gets the amount of memory that is required to load the module.
        //
        // Returns:
        //     The size, in bytes, of the memory that the module occupies.
        int ModuleMemorySize { get; }
        //
        // Summary:
        //     Gets the name of the process module.
        //
        // Returns:
        //     The name of the module.
        string ModuleName { get; }
    }

    public class StAbProcessModule : IProcessModule
    {
        public IntPtr BaseAddress { get; protected set; }

        public IntPtr EntryPointAddress { get; protected set; }

        public string FileName { get; protected set; }

        public IFileVersionInfoInstance FileVersionInfo { get; protected set; }

        public int ModuleMemorySize { get; protected set; }

        public string ModuleName { get; protected set; }

        public StAbProcessModule(ProcessModule module)
        {
            this.BaseAddress = module.BaseAddress;
            this.EntryPointAddress = module.EntryPointAddress;
            this.FileName = module.FileName;
            this.FileVersionInfo = new StAbFileVersionInfoInstance(module.FileVersionInfo);
            this.ModuleMemorySize = module.ModuleMemorySize;
            this.ModuleName = module.ModuleName;
        }
    }
}
