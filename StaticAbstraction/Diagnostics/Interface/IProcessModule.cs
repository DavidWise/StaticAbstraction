using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace StaticAbstraction.Diagnostics.Interface
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

#if NET40_OR_GREATER || NETCOREAPP3_0_OR_GREATER
        //
        // Summary:
        //     Gets version information about the module.
        //
        // Returns:
        //     A System.Diagnostics.FileVersionInfo that contains the module's version information.
        IFileVersionInfoInstance FileVersionInfo { get; }
#endif
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
}
