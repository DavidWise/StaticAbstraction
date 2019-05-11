﻿using StaticAbstraction.IO;

namespace StaticAbstraction
{
    public class StaticAbstractionWrapper : IStaticAbstraction
    {
        protected IFile _file;
        protected IPath _path;
        protected IDirectory _directory;
        protected IDriveInfo _driveInfo;
        protected IConsole _console;

        public IFile File {
            get {
                if (_file == null) _file = new StAbFile();
                return _file;
            }
            set { _file = value; }
        }

        public IPath Path
        {
            get
            {
                if (_path == null) _path = new StAbPath();
                return _path;
            }
            set { _path = value; }
        }

        public IDirectory Directory
        {
            get
            {
                if (_directory == null) _directory = new StAbDirectory();
                return _directory;
            }
            set { _directory = value; }
        }


        public IDriveInfo DriveInfo
        {
            get
            {
                if (_driveInfo == null) _driveInfo = new StAbDriveInfo();
                return _driveInfo;
            }
            set { _driveInfo = value; }
        }

        public IConsole Console
        {
            get
            {
                if (_console == null) _console = new StAbConsole();
                return _console;
            }
            set { _console = value; }
        }

        public StaticAbstractionWrapper()
        {
        }

        public StaticAbstractionWrapper(IFile file, IPath path, IDirectory directory, IConsole console, IDriveInfo driveInfo) : this()
        {
            this.File = file;
            this.Path = path;
            this.Directory = directory;
            this.Console = console;
            this.DriveInfo = driveInfo;
        }

        public IFileInfo NewFileInfo(string path)
        {
            return new StAbFileInfo(path);
        }

        public IDirectoryInfo NewDirectoryInfo(string path)
        {
            return new StAbDirectoryInfo(path);
        }
    }
}