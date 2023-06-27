using System;
using System.Collections;

namespace StaticAbstraction.Mocks
{
    public class MockEnvironment : IEnvironment
    {
        public virtual string CommandLine { get; set; }

        public virtual string CurrentDirectory { get; set; }

#if !NET40
        public virtual int CurrentManagedThreadId { get; set; }
#endif

        public virtual int ExitCode { get; set; }

        public virtual bool HasShutdownStarted { get; set; }

        public virtual bool Is64BitOperatingSystem { get; set; }

        public virtual bool Is64BitProcess { get; set; }

        public virtual string MachineName { get; set; }

        public virtual string NewLine { get; set; }

        public virtual OperatingSystem OSVersion { get; set; }

#if NETCORE50 || NETCORE60 || NETCORE70
        public virtual Int32 ProcessId { get; set; }
#endif

        public virtual int ProcessorCount { get; set; }

#if NETCORE60 || NETCORE70
        public virtual string ProcessPath { get; set; }
#endif

        public virtual string StackTrace { get; set; }

        public virtual string SystemDirectory { get; set; }

        public virtual int SystemPageSize { get; set; }

        public virtual int TickCount { get; set; }

#if NETCORE30 || NETCORE31 || NETCORE50 || NETCORE60 || NETCORE70
        public virtual long TickCount64 { get; set; }
#endif

        public virtual string UserDomainName { get; set; }

        public virtual bool UserInteractive { get; set; }

        public virtual string UserName { get; set; }

        public virtual Version Version { get; set; }

        public virtual long WorkingSet { get; set; }

        public virtual void Exit(int exitCode) { }

        public virtual string ExpandEnvironmentVariables(string name) => null;

        public virtual void FailFast(string message) { }

        public virtual void FailFast(string message, Exception exception) { }

        public virtual string[] GetCommandLineArgs() => default(string[]);

        public virtual string GetEnvironmentVariable(string variable) => null;

        public virtual string GetEnvironmentVariable(string variable, EnvironmentVariableTarget target) => null;

        public virtual IDictionary GetEnvironmentVariables() => null;

        public virtual IDictionary GetEnvironmentVariables(EnvironmentVariableTarget target) => null;

        public virtual string GetFolderPath(Environment.SpecialFolder folder) => null;

        public virtual string GetFolderPath(Environment.SpecialFolder folder, Environment.SpecialFolderOption option) => null;

        public virtual string[] GetLogicalDrives() => null;

        public virtual void SetEnvironmentVariable(string variable, string value) { }

        public virtual void SetEnvironmentVariable(string variable, string value, EnvironmentVariableTarget target) { }
    }
}
