﻿using StaticAbstraction.Diagnostics;
using StaticAbstraction.IO;
using StaticAbstraction.Reflection;

namespace StaticAbstraction
{
    /// This whole file exists so that unit tests can be run without needing to have existing files in place

    public interface IStaticAbstraction
    {
        IFile File { get; set; }
        IPath Path { get; set; }
        IDirectory Directory { get; set; }
        IDriveInfo DriveInfo { get; set; }
        IConsole Console { get; set; }
        IDateTime DateTime { get; set; }
        IAssembly Assembly { get; set; }
        IEnvironment Environment { get; set; }
        IProcess Process { get; set; }

        IFileInfo NewFileInfo(string path);
        IDirectoryInfo NewDirectoryInfo(string path);
    }
}
