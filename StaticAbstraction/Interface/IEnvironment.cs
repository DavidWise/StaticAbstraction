using System;
using System.Collections;
using static System.Environment;

namespace StaticAbstraction
{
    public interface IEnvironment
    {
        String CommandLine { get; }
        String CurrentDirectory { get; set; }

#if !NET40
        Int32 CurrentManagedThreadId { get; }
#endif

        Int32 ExitCode { get; set; }
        Boolean HasShutdownStarted { get; }
        Boolean Is64BitOperatingSystem { get; }
        Boolean Is64BitProcess { get; }
        String MachineName { get; }
        String NewLine { get; }
        OperatingSystem OSVersion { get; }

#if NET5_0_OR_GREATER
        Int32 ProcessId { get; }
#endif

        Int32 ProcessorCount { get; }

#if NET6_0_OR_GREATER
        string ProcessPath { get; }
#endif
        String StackTrace { get; }
        String SystemDirectory { get; }
        Int32 SystemPageSize { get; }
        Int32 TickCount { get; }

#if NETCOREAPP3_0_OR_GREATER
        Int64 TickCount64 { get; }
#endif
        String UserDomainName { get; }
        Boolean UserInteractive { get; }
        String UserName { get; }
        Version Version { get; }
        Int64 WorkingSet { get; }
        void Exit(Int32 exitCode);
        String ExpandEnvironmentVariables(String name);
        void FailFast(String message);
        void FailFast(String message, Exception exception);

        // This is visiable via reflection but does not seem to be available
        //void FailFast(String message, Exception exception, String errorMessage);

        String[] GetCommandLineArgs();
        String GetEnvironmentVariable(String variable);
        String GetEnvironmentVariable(String variable, EnvironmentVariableTarget target);
        IDictionary GetEnvironmentVariables();
        IDictionary GetEnvironmentVariables(EnvironmentVariableTarget target);
        String GetFolderPath(SpecialFolder folder);
        String GetFolderPath(SpecialFolder folder, SpecialFolderOption option);
        String[] GetLogicalDrives();
        void SetEnvironmentVariable(String variable, String value);
        void SetEnvironmentVariable(String variable, String value, EnvironmentVariableTarget target);
    }
}
