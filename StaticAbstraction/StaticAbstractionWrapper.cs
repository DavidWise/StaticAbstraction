using StaticAbstraction.Diagnostics;
using StaticAbstraction.Diagnostics.Interface;
using StaticAbstraction.IO;
using StaticAbstraction.Reflection;
using System.ComponentModel;

namespace StaticAbstraction
{
    public class StAbWrapper : IStaticAbstraction
    {
        protected IFile _file;
        protected IPath _path;
        protected IDirectory _directory;
        protected IDriveInfo _driveInfo;
        protected IConsole _console;
        protected IDateTime _dateTime;
        protected IAssembly _assembly;
        protected IEnvironment _environment;

#if NETCOREAPP3_0_OR_GREATER
        protected IProcess _process;
#endif

        public virtual IFile File {
            get {
                if (_file == null) _file = new StAbFile();
                return _file;
            }
            set { _file = value; }
        }

        public virtual IPath Path
        {
            get
            {
                if (_path == null) _path = new StAbPath();
                return _path;
            }
            set { _path = value; }
        }

        public virtual IDirectory Directory
        {
            get
            {
                if (_directory == null) _directory = new StAbDirectory();
                return _directory;
            }
            set { _directory = value; }
        }


        public virtual IDriveInfo DriveInfo
        {
            get
            {
                if (_driveInfo == null) _driveInfo = new StAbDriveInfo();
                return _driveInfo;
            }
            set { _driveInfo = value; }
        }

        public virtual IConsole Console
        {
            get
            {
                if (_console == null) _console = new StAbConsole();
                return _console;
            }
            set { _console = value; }
        }

        public virtual IDateTime DateTime
        {
            get
            {
                if (_dateTime == null) _dateTime = new StAbDateTime();
                return _dateTime;
            }
            set { _dateTime = value; }
        }

        public virtual IAssembly Assembly
        {
            get
            {
                if (_assembly == null) _assembly = new StAbAssembly();
                return _assembly;
            }
            set { _assembly = value; }
        }

        public virtual IEnvironment Environment
        {
            get
            {
                if (_environment == null) _environment = new StAbEnvironment();
                return _environment;
            }
            set { _environment = value; }
        }

#if NETCOREAPP3_0_OR_GREATER
        public virtual IProcess Process
        {
            get
            {
                if (_process == null) _process = new StAbProcess();
                return _process;
            }
            set { _process = value; }
        }
#endif

        public StAbWrapper()
        {
        }
#if NET40_OR_GREATER
        public StAbWrapper(IFile file, IPath path, IDirectory directory, IConsole console, IDriveInfo driveInfo, IDateTime dateTime, IAssembly assembly, IEnvironment environment) : this()
        {
            Init(file, path, directory, console, driveInfo, dateTime, assembly, environment);
        }
#endif

#if NETCOREAPP3_0_OR_GREATER
        public StAbWrapper(IFile file, IPath path, IDirectory directory, IConsole console, IDriveInfo driveInfo, IDateTime dateTime, IAssembly assembly, IEnvironment environment, IProcess process) : this()
        {
            Init(file, path, directory, console, driveInfo, dateTime, assembly, environment);
            if (process != null) this.Process = process;
        }
#endif

        private void Init(IFile file, IPath path, IDirectory directory, IConsole console, IDriveInfo driveInfo, IDateTime dateTime, IAssembly assembly, IEnvironment environment)
        {
            if (file != null) this.File = file;
            if (path != null) this.Path = path;
            if (directory != null) this.Directory = directory;
            if (console != null) this.Console = console;
            if (driveInfo != null) this.DriveInfo = driveInfo;
            if (dateTime != null) this.DateTime = dateTime;
            if (assembly != null) this.Assembly = assembly;
            if (environment != null) this.Environment = environment;
        }

        public virtual IFileInfo NewFileInfo(string path)
        {
            return new StAbFileInfo(path);
        }

        public virtual IDirectoryInfo NewDirectoryInfo(string path)
        {
            return new StAbDirectoryInfo(path);
        }
    }
}
