using System;
using System.Collections;

namespace StaticAbstraction
{
    public class StAbEnvironment : IEnvironment
    {
        public virtual string CommandLine => Environment.CommandLine;

        public virtual string CurrentDirectory { get => Environment.CurrentDirectory; set => Environment.CurrentDirectory = value; }

#if !NET40
        public virtual int CurrentManagedThreadId => Environment.CurrentManagedThreadId;
#endif

        public virtual int ExitCode { get => Environment.ExitCode;  set => Environment.ExitCode = value; }

        public virtual bool HasShutdownStarted => Environment.HasShutdownStarted;

        public virtual bool Is64BitOperatingSystem => Environment.Is64BitOperatingSystem;

        public virtual bool Is64BitProcess => Environment.Is64BitProcess;

        public virtual string MachineName => Environment.MachineName;

        public virtual string NewLine => Environment.NewLine;

        public virtual OperatingSystem OSVersion => Environment.OSVersion;

#if NETCORE50 || NETCORE60
        public virtual Int32 ProcessId  => Environment.ProcessId;
#endif

        public virtual int ProcessorCount => Environment.ProcessorCount;

        public virtual string StackTrace => Environment.StackTrace;

        public virtual string SystemDirectory => Environment.SystemDirectory;

        public virtual int SystemPageSize => Environment.SystemPageSize;

        public virtual int TickCount => Environment.TickCount;

#if NETCORE30 || NETCORE31 || NETCORE50 || NETCORE60
        public virtual long TickCount64 => Environment.TickCount64;
#endif

        public virtual string UserDomainName => Environment.UserDomainName;

        public virtual bool UserInteractive => Environment.UserInteractive;

        public virtual string UserName => Environment.UserName;

        public virtual Version Version => Environment.Version;

        public virtual long WorkingSet => Environment.WorkingSet;
                
        public virtual void Exit(int exitCode)=> Environment.Exit(exitCode);

        public virtual string ExpandEnvironmentVariables(string name) => Environment.ExpandEnvironmentVariables(name);

        public virtual void FailFast(string message) => Environment.FailFast(message);

        public virtual void FailFast(string message, Exception exception) => Environment.FailFast(message, exception);

        //public virtual void FailFast(string message, Exception exception, string errorMessage) => Environment.FailFast(message, exception, errorMessage);

        public virtual string[] GetCommandLineArgs() => Environment.GetCommandLineArgs();


        public virtual string GetEnvironmentVariable(string variable) => Environment.GetEnvironmentVariable(variable);

        public virtual string GetEnvironmentVariable(string variable, EnvironmentVariableTarget target) => Environment.GetEnvironmentVariable(variable, target);

        public virtual IDictionary GetEnvironmentVariables() => Environment.GetEnvironmentVariables();

        public virtual IDictionary GetEnvironmentVariables(EnvironmentVariableTarget target) => Environment.GetEnvironmentVariables(target);

        public virtual string GetFolderPath(Environment.SpecialFolder folder) => Environment.GetFolderPath(folder);

        public virtual string GetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) => Environment.GetFolderPath(folder, option);

        public virtual string[] GetLogicalDrives() => Environment.GetLogicalDrives();

        public virtual void SetEnvironmentVariable(string variable, string value) => Environment.SetEnvironmentVariable(variable, value);

        public virtual void SetEnvironmentVariable(string variable, string value, EnvironmentVariableTarget target) => Environment.SetEnvironmentVariable(variable, value, target);
    }
}
