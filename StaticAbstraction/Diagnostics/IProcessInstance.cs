using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace StaticAbstraction.Diagnostics
{
    public interface IProcessInstance : IComponent, IDisposable
    {
        //
        // Summary:
        //     Gets or sets the overall priority category for the associated process.
        //
        // Returns:
        //     The priority category for the associated process, from which the System.Diagnostics.Process.BasePriority
        //     of the process is calculated.
        //
        // Exceptions:
        //   T:System.ComponentModel.Win32Exception:
        //     Process priority information could not be set or retrieved from the associated
        //     process resource. -or- The process identifier or process handle is zero. (The
        //     process has not been started.)
        //
        //   T:System.NotSupportedException:
        //     You are attempting to access the System.Diagnostics.Process.PriorityClass property
        //     for a process that is running on a remote computer. This property is available
        //     only for processes that are running on the local computer.
        //
        //   T:System.InvalidOperationException:
        //     The process System.Diagnostics.Process.Id is not available.
        //
        //   T:System.ComponentModel.InvalidEnumArgumentException:
        //     Priority class cannot be set because it does not use a valid value, as defined
        //     in the System.Diagnostics.ProcessPriorityClass enumeration.
        ProcessPriorityClass PriorityClass { get; set; }
        //
        // Summary:
        //     Gets or sets a value indicating whether the associated process priority should
        //     temporarily be boosted by the operating system when the main window has the focus.
        //
        // Returns:
        //     true if dynamic boosting of the process priority should take place for a process
        //     when it is taken out of the wait state; otherwise, false. The default is false.
        //
        // Exceptions:
        //   T:System.ComponentModel.Win32Exception:
        //     Priority boost information could not be retrieved from the associated process
        //     resource.
        //
        //   T:System.PlatformNotSupportedException:
        //     The process identifier or process handle is zero. (The process has not been started.)
        //
        //   T:System.NotSupportedException:
        //     You are attempting to access the System.Diagnostics.Process.PriorityBoostEnabled
        //     property for a process that is running on a remote computer. This property is
        //     available only for processes that are running on the local computer.
        //
        //   T:System.InvalidOperationException:
        //     The process System.Diagnostics.Process.Id is not available.
        bool PriorityBoostEnabled { get; set; }
        //
        // Summary:
        //     Gets the maximum amount of physical memory, in bytes, used by the associated
        //     process.
        //
        // Returns:
        //     The maximum amount of physical memory, in bytes, allocated for the associated
        //     process since it was started.
        long PeakWorkingSet64 { get; }
        //
        // Summary:
        //     Gets the peak working set size for the associated process, in bytes.
        //
        // Returns:
        //     The maximum amount of physical memory that the associated process has required
        //     all at once, in bytes.
        [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PeakWorkingSet64 instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        int PeakWorkingSet { get; }
        //
        // Summary:
        //     Gets the maximum amount of virtual memory, in bytes, used by the associated process.
        //
        // Returns:
        //     The maximum amount of virtual memory, in bytes, allocated for the associated
        //     process since it was started.
        long PeakVirtualMemorySize64 { get; }
        //
        // Summary:
        //     Gets the maximum amount of virtual memory, in bytes, used by the associated process.
        //
        // Returns:
        //     The maximum amount of virtual memory, in bytes, that the associated process has
        //     requested.
        [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PeakVirtualMemorySize64 instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        int PeakVirtualMemorySize { get; }
        //
        // Summary:
        //     Gets the maximum amount of memory in the virtual memory paging file, in bytes,
        //     used by the associated process.
        //
        // Returns:
        //     The maximum amount of memory, in bytes, allocated in the virtual memory paging
        //     file for the associated process since it was started.
        long PeakPagedMemorySize64 { get; }
        //
        // Summary:
        //     Gets the maximum amount of memory in the virtual memory paging file, in bytes,
        //     used by the associated process.
        //
        // Returns:
        //     The maximum amount of memory, in bytes, allocated by the associated process that
        //     could be written to the virtual memory paging file.
        [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PeakPagedMemorySize64 instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        int PeakPagedMemorySize { get; }
        //
        // Summary:
        //     Gets the amount of pageable system memory, in bytes, allocated for the associated
        //     process.
        //
        // Returns:
        //     The amount of system memory, in bytes, allocated for the associated process that
        //     can be written to the virtual memory paging file.
        long PagedSystemMemorySize64 { get; }
        //
        // Summary:
        //     Gets the amount of pageable system memory, in bytes, allocated for the associated
        //     process.
        //
        // Returns:
        //     The amount of memory, in bytes, the system has allocated for the associated process
        //     that can be written to the virtual memory paging file.
        [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PagedSystemMemorySize64 instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        int PagedSystemMemorySize { get; }
        //
        // Summary:
        //     Gets the amount of paged memory, in bytes, allocated for the associated process.
        //
        // Returns:
        //     The amount of memory, in bytes, allocated in the virtual memory paging file for
        //     the associated process.
        long PagedMemorySize64 { get; }
        //
        // Summary:
        //     Gets the amount of paged memory, in bytes, allocated for the associated process.
        //
        // Returns:
        //     The amount of memory, in bytes, allocated by the associated process that can
        //     be written to the virtual memory paging file.
        [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PagedMemorySize64 instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        int PagedMemorySize { get; }
        //
        // Summary:
        //     Gets the amount of nonpaged system memory, in bytes, allocated for the associated
        //     process.
        //
        // Returns:
        //     The amount of system memory, in bytes, allocated for the associated process that
        //     cannot be written to the virtual memory paging file.
        long NonpagedSystemMemorySize64 { get; }
        //
        // Summary:
        //     Gets the amount of nonpaged system memory, in bytes, allocated for the associated
        //     process.
        //
        // Returns:
        //     The amount of memory, in bytes, the system has allocated for the associated process
        //     that cannot be written to the virtual memory paging file.
        [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.NonpagedSystemMemorySize64 instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        int NonpagedSystemMemorySize { get; }
        //
        // Summary:
        //     Gets the modules that have been loaded by the associated process.
        //
        // Returns:
        //     An array of type System.Diagnostics.ProcessModule that represents the modules
        //     that have been loaded by the associated process.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     You are attempting to access the System.Diagnostics.Process.Modules property
        //     for a process that is running on a remote computer. This property is available
        //     only for processes that are running on the local computer.
        //
        //   T:System.InvalidOperationException:
        //     The process System.Diagnostics.Process.Id is not available.
        //
        //   T:System.ComponentModel.Win32Exception:
        //     You are attempting to access the System.Diagnostics.Process.Modules property
        //     for either the system process or the idle process. These processes do not have
        //     modules.
        ProcessModuleCollection Modules { get; }
        //
        // Summary:
        //     Gets or sets the minimum allowable working set size, in bytes, for the associated
        //     process.
        //
        // Returns:
        //     The minimum working set size that is required in memory for the process, in bytes.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The minimum working set size is invalid. It must be less than or equal to the
        //     maximum working set size.
        //
        //   T:System.ComponentModel.Win32Exception:
        //     Working set information cannot be retrieved from the associated process resource.
        //     -or- The process identifier or process handle is zero because the process has
        //     not been started.
        //
        //   T:System.NotSupportedException:
        //     You are trying to access the System.Diagnostics.Process.MinWorkingSet property
        //     for a process that is running on a remote computer. This property is available
        //     only for processes that are running on the local computer.
        //
        //   T:System.InvalidOperationException:
        //     The process System.Diagnostics.Process.Id is not available. -or- The process
        //     has exited.
        IntPtr MinWorkingSet { get; set; }
        //
        // Summary:
        //     Gets or sets the maximum allowable working set size, in bytes, for the associated
        //     process.
        //
        // Returns:
        //     The maximum working set size that is allowed in memory for the process, in bytes.
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     The maximum working set size is invalid. It must be greater than or equal to
        //     the minimum working set size.
        //
        //   T:System.ComponentModel.Win32Exception:
        //     Working set information cannot be retrieved from the associated process resource.
        //     -or- The process identifier or process handle is zero because the process has
        //     not been started.
        //
        //   T:System.NotSupportedException:
        //     You are trying to access the System.Diagnostics.Process.MaxWorkingSet property
        //     for a process that is running on a remote computer. This property is available
        //     only for processes that are running on the local computer.
        //
        //   T:System.InvalidOperationException:
        //     The process System.Diagnostics.Process.Id is not available. -or- The process
        //     has exited.
        IntPtr MaxWorkingSet { get; set; }
        //
        // Summary:
        //     Gets the amount of private memory, in bytes, allocated for the associated process.
        //
        // Returns:
        //     The number of bytes allocated by the associated process that cannot be shared
        //     with other processes.
        [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PrivateMemorySize64 instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        int PrivateMemorySize { get; }
        //
        // Summary:
        //     Gets the caption of the main window of the process.
        //
        // Returns:
        //     The main window title of the process.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Diagnostics.Process.MainWindowTitle property is not defined because
        //     the process has exited.
        //
        //   T:System.NotSupportedException:
        //     You are trying to access the System.Diagnostics.Process.MainWindowTitle property
        //     for a process that is running on a remote computer. This property is available
        //     only for processes that are running on the local computer.
        string MainWindowTitle { get; }
        //
        // Summary:
        //     Gets the amount of private memory, in bytes, allocated for the associated process.
        //
        // Returns:
        //     The amount of memory, in bytes, allocated for the associated process that cannot
        //     be shared with other processes.
        long PrivateMemorySize64 { get; }
        //
        // Summary:
        //     Gets the name of the process.
        //
        // Returns:
        //     The name that the system uses to identify the process to the user.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The process does not have an identifier, or no process is associated with the
        //     System.Diagnostics.Process. -or- The associated process has exited.
        //
        //   T:System.NotSupportedException:
        //     The process is not on this computer.
        string ProcessName { get; }
        //
        // Summary:
        //     Gets the amount of physical memory, in bytes, allocated for the associated process.
        //
        // Returns:
        //     The amount of physical memory, in bytes, allocated for the associated process.
        long WorkingSet64 { get; }
        //
        // Summary:
        //     Gets the associated process's physical memory usage, in bytes.
        //
        // Returns:
        //     The total amount of physical memory the associated process is using, in bytes.
        [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.WorkingSet64 instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        int WorkingSet { get; }
        //
        // Summary:
        //     Gets the amount of the virtual memory, in bytes, allocated for the associated
        //     process.
        //
        // Returns:
        //     The amount of virtual memory, in bytes, allocated for the associated process.
        long VirtualMemorySize64 { get; }
        //
        // Summary:
        //     Gets the size of the process's virtual memory, in bytes.
        //
        // Returns:
        //     The amount of virtual memory, in bytes, that the associated process has requested.
        [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.VirtualMemorySize64 instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        int VirtualMemorySize { get; }
        //
        // Summary:
        //     Gets the user processor time for this process.
        //
        // Returns:
        //     A System.TimeSpan that indicates the amount of time that the associated process
        //     has spent running code inside the application portion of the process (not inside
        //     the operating system core).
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     You are attempting to access the System.Diagnostics.Process.UserProcessorTime
        //     property for a process that is running on a remote computer. This property is
        //     available only for processes that are running on the local computer.
        TimeSpan UserProcessorTime { get; }
        //
        // Summary:
        //     Gets the total processor time for this process.
        //
        // Returns:
        //     A System.TimeSpan that indicates the amount of time that the associated process
        //     has spent utilizing the CPU. This value is the sum of the System.Diagnostics.Process.UserProcessorTime
        //     and the System.Diagnostics.Process.PrivilegedProcessorTime.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     You are attempting to access the System.Diagnostics.Process.TotalProcessorTime
        //     property for a process that is running on a remote computer. This property is
        //     available only for processes that are running on the local computer.
        TimeSpan TotalProcessorTime { get; }
        //
        // Summary:
        //     Gets the set of threads that are running in the associated process.
        //
        // Returns:
        //     An array of type System.Diagnostics.ProcessThread representing the operating
        //     system threads currently running in the associated process.
        //
        // Exceptions:
        //   T:System.SystemException:
        //     The process does not have an System.Diagnostics.Process.Id, or no process is
        //     associated with the System.Diagnostics.Process instance. -or- The associated
        //     process has exited.
        ProcessThreadCollection Threads { get; }
        //
        // Summary:
        //     Gets or sets the object used to marshal the event handler calls that are issued
        //     as a result of a process exit event.
        //
        // Returns:
        //     The System.ComponentModel.ISynchronizeInvoke used to marshal event handler calls
        //     that are issued as a result of an System.Diagnostics.Process.Exited event on
        //     the process.
        ISynchronizeInvoke SynchronizingObject { get; set; }
        //
        // Summary:
        //     Gets the time that the associated process was started.
        //
        // Returns:
        //     An object that indicates when the process started. An exception is thrown if
        //     the process is not running.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     You are attempting to access the System.Diagnostics.Process.StartTime property
        //     for a process that is running on a remote computer. This property is available
        //     only for processes that are running on the local computer.
        //
        //   T:System.InvalidOperationException:
        //     The process has exited. -or- The process has not been started.
        //
        //   T:System.ComponentModel.Win32Exception:
        //     An error occurred in the call to the Windows function.
        DateTime StartTime { get; }
        //
        // Summary:
        //     Gets or sets the properties to pass to the System.Diagnostics.Process.Start method
        //     of the System.Diagnostics.Process.
        //
        // Returns:
        //     The System.Diagnostics.ProcessStartInfo that represents the data with which to
        //     start the process. These arguments include the name of the executable file or
        //     document used to start the process.
        //
        // Exceptions:
        //   T:System.ArgumentNullException:
        //     The value that specifies the System.Diagnostics.Process.StartInfo is null.
        //
        //   T:System.InvalidOperationException:
        //     The System.Diagnostics.Process.Start method was not used to start the process.
        ProcessStartInfo StartInfo { get; set; }
        //
        // Summary:
        //     Gets a stream used to read the textual output of the application.
        //
        // Returns:
        //     A System.IO.StreamReader that can be used to read the standard output stream
        //     of the application.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Diagnostics.Process.StandardOutput stream has not been defined for
        //     redirection; ensure System.Diagnostics.ProcessStartInfo.RedirectStandardOutput
        //     is set to true and System.Diagnostics.ProcessStartInfo.UseShellExecute is set
        //     to false. -or- The System.Diagnostics.Process.StandardOutput stream has been
        //     opened for asynchronous read operations with System.Diagnostics.Process.BeginOutputReadLine.
        StreamReader StandardOutput { get; }
        //
        // Summary:
        //     Gets a stream used to write the input of the application.
        //
        // Returns:
        //     A System.IO.StreamWriter that can be used to write the standard input stream
        //     of the application.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Diagnostics.Process.StandardInput stream has not been defined because
        //     System.Diagnostics.ProcessStartInfo.RedirectStandardInput is set to false.
        StreamWriter StandardInput { get; }
        //
        // Summary:
        //     Gets a stream used to read the error output of the application.
        //
        // Returns:
        //     A System.IO.StreamReader that can be used to read the standard error stream of
        //     the application.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Diagnostics.Process.StandardError stream has not been defined for
        //     redirection; ensure System.Diagnostics.ProcessStartInfo.RedirectStandardError
        //     is set to true and System.Diagnostics.ProcessStartInfo.UseShellExecute is set
        //     to false. -or- The System.Diagnostics.Process.StandardError stream has been opened
        //     for asynchronous read operations with System.Diagnostics.Process.BeginErrorReadLine.
        StreamReader StandardError { get; }
        //
        // Summary:
        //     Gets the Terminal Services session identifier for the associated process.
        //
        // Returns:
        //     The Terminal Services session identifier for the associated process.
        //
        // Exceptions:
        //   T:System.NullReferenceException:
        //     There is no session associated with this process.
        //
        //   T:System.InvalidOperationException:
        //     There is no process associated with this session identifier. -or- The associated
        //     process is not on this machine.
        int SessionId { get; }

#if !NET40 && !NET45
        //
        // Summary:
        //     Gets the native handle to this process.
        //
        // Returns:
        //     The native handle to this process.
        SafeProcessHandle SafeHandle { get; }
#endif
        //
        // Summary:
        //     Gets a value indicating whether the user interface of the process is responding.
        //
        // Returns:
        //     true if the user interface of the associated process is responding to the system;
        //     otherwise, false.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     There is no process associated with this System.Diagnostics.Process object.
        //
        //   T:System.NotSupportedException:
        //     You are attempting to access the System.Diagnostics.Process.Responding property
        //     for a process that is running on a remote computer. This property is available
        //     only for processes that are running on the local computer.
        bool Responding { get; }
        //
        // Summary:
        //     Gets or sets the processors on which the threads in this process can be scheduled
        //     to run.
        //
        // Returns:
        //     A bitmask representing the processors that the threads in the associated process
        //     can run on. The default depends on the number of processors on the computer.
        //     The default value is 2 n -1, where n is the number of processors.
        //
        // Exceptions:
        //   T:System.ComponentModel.Win32Exception:
        //     System.Diagnostics.Process.ProcessorAffinity information could not be set or
        //     retrieved from the associated process resource. -or- The process identifier or
        //     process handle is zero. (The process has not been started.)
        //
        //   T:System.NotSupportedException:
        //     You are attempting to access the System.Diagnostics.Process.ProcessorAffinity
        //     property for a process that is running on a remote computer. This property is
        //     available only for processes that are running on the local computer.
        //
        //   T:System.InvalidOperationException:
        //     The process System.Diagnostics.Process.Id was not available. -or- The process
        //     has exited.
        IntPtr ProcessorAffinity { get; set; }
        //
        // Summary:
        //     Gets the privileged processor time for this process.
        //
        // Returns:
        //     A System.TimeSpan that indicates the amount of time that the process has spent
        //     running code inside the operating system core.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     You are attempting to access the System.Diagnostics.Process.PrivilegedProcessorTime
        //     property for a process that is running on a remote computer. This property is
        //     available only for processes that are running on the local computer.
        TimeSpan PrivilegedProcessorTime { get; }
        //
        // Summary:
        //     Gets the main module for the associated process.
        //
        // Returns:
        //     The System.Diagnostics.ProcessModule that was used to start the process.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     You are trying to access the System.Diagnostics.Process.MainModule property for
        //     a process that is running on a remote computer. This property is available only
        //     for processes that are running on the local computer.
        //
        //   T:System.ComponentModel.Win32Exception:
        //     A 32-bit process is trying to access the modules of a 64-bit process.
        //
        //   T:System.InvalidOperationException:
        //     The process System.Diagnostics.Process.Id is not available. -or- The process
        //     has exited.
        ProcessModule MainModule { get; }
        //
        // Summary:
        //     Gets the window handle of the main window of the associated process.
        //
        // Returns:
        //     The system-generated window handle of the main window of the associated process.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Diagnostics.Process.MainWindowHandle is not defined because the process
        //     has exited.
        //
        //   T:System.NotSupportedException:
        //     You are trying to access the System.Diagnostics.Process.MainWindowHandle property
        //     for a process that is running on a remote computer. This property is available
        //     only for processes that are running on the local computer.
        IntPtr MainWindowHandle { get; }
        //
        // Summary:
        //     Gets the unique identifier for the associated process.
        //
        // Returns:
        //     The system-generated unique identifier of the process that is referenced by this
        //     System.Diagnostics.Process instance.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The process's System.Diagnostics.Process.Id property has not been set. -or- There
        //     is no process associated with this System.Diagnostics.Process object.
        int Id { get; }
        //
        // Summary:
        //     Gets a value indicating whether the associated process has been terminated.
        //
        // Returns:
        //     true if the operating system process referenced by the System.Diagnostics.Process
        //     component has terminated; otherwise, false.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     There is no process associated with the object.
        //
        //   T:System.ComponentModel.Win32Exception:
        //     The exit code for the process could not be retrieved.
        //
        //   T:System.NotSupportedException:
        //     You are trying to access the System.Diagnostics.Process.HasExited property for
        //     a process that is running on a remote computer. This property is available only
        //     for processes that are running on the local computer.
        bool HasExited { get; }
        //
        // Summary:
        //     Gets the number of handles opened by the process.
        //
        // Returns:
        //     The number of operating system handles the process has opened.
        int HandleCount { get; }
        //
        // Summary:
        //     Gets the native handle of the associated process.
        //
        // Returns:
        //     The handle that the operating system assigned to the associated process when
        //     the process was started. The system uses this handle to keep track of process
        //     attributes.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The process has not been started or has exited. The System.Diagnostics.Process.Handle
        //     property cannot be read because there is no process associated with this System.Diagnostics.Process
        //     instance. -or- The System.Diagnostics.Process instance has been attached to a
        //     running process but you do not have the necessary permissions to get a handle
        //     with full access rights.
        //
        //   T:System.NotSupportedException:
        //     You are trying to access the System.Diagnostics.Process.Handle property for a
        //     process that is running on a remote computer. This property is available only
        //     for processes that are running on the local computer.
        IntPtr Handle { get; }
        //
        // Summary:
        //     Gets the time that the associated process exited.
        //
        // Returns:
        //     A System.DateTime that indicates when the associated process was terminated.
        //
        // Exceptions:
        //   T:System.NotSupportedException:
        //     You are trying to access the System.Diagnostics.Process.ExitTime property for
        //     a process that is running on a remote computer. This property is available only
        //     for processes that are running on the local computer.
        DateTime ExitTime { get; }
        //
        // Summary:
        //     Gets the value that the associated process specified when it terminated.
        //
        // Returns:
        //     The code that the associated process specified when it terminated.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The process has not exited. -or- The process System.Diagnostics.Process.Handle
        //     is not valid.
        //
        //   T:System.NotSupportedException:
        //     You are trying to access the System.Diagnostics.Process.ExitCode property for
        //     a process that is running on a remote computer. This property is available only
        //     for processes that are running on the local computer.
        int ExitCode { get; }
        //
        // Summary:
        //     Gets or sets whether the System.Diagnostics.Process.Exited event should be raised
        //     when the process terminates.
        //
        // Returns:
        //     true if the System.Diagnostics.Process.Exited event should be raised when the
        //     associated process is terminated (through either an exit or a call to System.Diagnostics.Process.Kill);
        //     otherwise, false. The default is false. Note that the System.Diagnostics.Process.Exited
        //     event is raised even if the value of System.Diagnostics.Process.EnableRaisingEvents
        //     is false when the process exits during or before the user performs a System.Diagnostics.Process.HasExited
        //     check.
        bool EnableRaisingEvents { get; set; }
        //
        // Summary:
        //     Gets the base priority of the associated process.
        //
        // Returns:
        //     The base priority, which is computed from the System.Diagnostics.Process.PriorityClass
        //     of the associated process.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The process has exited. -or- The process has not started, so there is no process
        //     ID.
        int BasePriority { get; }
        //
        // Summary:
        //     Gets the name of the computer the associated process is running on.
        //
        // Returns:
        //     The name of the computer that the associated process is running on.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     There is no process associated with this System.Diagnostics.Process object.
        string MachineName { get; }
        //
        // Summary:
        //     Begins asynchronous read operations on the redirected System.Diagnostics.Process.StandardError
        //     stream of the application.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Diagnostics.ProcessStartInfo.RedirectStandardError property is false.
        //     -or- An asynchronous read operation is already in progress on the System.Diagnostics.Process.StandardError
        //     stream. -or- The System.Diagnostics.Process.StandardError stream has been used
        //     by a synchronous read operation.
        void BeginErrorReadLine();
        //
        // Summary:
        //     Begins asynchronous read operations on the redirected System.Diagnostics.Process.StandardOutput
        //     stream of the application.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Diagnostics.ProcessStartInfo.RedirectStandardOutput property is false.
        //     -or- An asynchronous read operation is already in progress on the System.Diagnostics.Process.StandardOutput
        //     stream. -or- The System.Diagnostics.Process.StandardOutput stream has been used
        //     by a synchronous read operation.
        void BeginOutputReadLine();
        //
        // Summary:
        //     Cancels the asynchronous read operation on the redirected System.Diagnostics.Process.StandardError
        //     stream of an application.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Diagnostics.Process.StandardError stream is not enabled for asynchronous
        //     read operations.
        void CancelErrorRead();
        //
        // Summary:
        //     Cancels the asynchronous read operation on the redirected System.Diagnostics.Process.StandardOutput
        //     stream of an application.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The System.Diagnostics.Process.StandardOutput stream is not enabled for asynchronous
        //     read operations.
        void CancelOutputRead();
        //
        // Summary:
        //     Frees all the resources that are associated with this component.
        void Close();
        //
        // Summary:
        //     Closes a process that has a user interface by sending a close message to its
        //     main window.
        //
        // Returns:
        //     true if the close message was successfully sent; false if the associated process
        //     does not have a main window or if the main window is disabled (for example if
        //     a modal dialog is being shown).
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The process has already exited. -or- No process is associated with this System.Diagnostics.Process
        //     object.
        bool CloseMainWindow();

#if NETCOREAPP3_0_OR_GREATER
        //
        // Summary:
        //     Immediately stops the associated process, and optionally its child/descendent
        //     processes.
        //
        // Parameters:
        //   entireProcessTree:
        //     true to kill the associated process and its descendants; false to kill only the
        //     associated process.
        //
        // Exceptions:
        //   T:System.ComponentModel.Win32Exception:
        //     The associated process could not be terminated. -or- The process is terminating.
        //
        //   T:System.NotSupportedException:
        //     You are attempting to call System.Diagnostics.Process.Kill for a process that
        //     is running on a remote computer. The method is available only for processes running
        //     on the local computer.
        //
        //   T:System.InvalidOperationException:
        //     The process has already exited. -or- There is no process associated with this
        //     System.Diagnostics.Process object. -or- The calling process is a member of the
        //     associated process' descendant tree.
        //
        //   T:System.AggregateException:
        //     Not all processes in the associated process' descendant tree could be terminated.
        void Kill(bool entireProcessTree);
#endif
        //
        // Summary:
        //     Immediately stops the associated process.
        //
        // Exceptions:
        //   T:System.ComponentModel.Win32Exception:
        //     The associated process could not be terminated. -or- The process is terminating.
        //
        //   T:System.NotSupportedException:
        //     You are attempting to call System.Diagnostics.Process.Kill for a process that
        //     is running on a remote computer. The method is available only for processes running
        //     on the local computer.
        //
        //   T:System.InvalidOperationException:
        //     The process has already exited. -or- There is no process associated with this
        //     System.Diagnostics.Process object.
        void Kill();
        //
        // Summary:
        //     Discards any information about the associated process that has been cached inside
        //     the process component.
        void Refresh();
        //
        // Summary:
        //     Starts (or reuses) the process resource that is specified by the System.Diagnostics.Process.StartInfo
        //     property of this System.Diagnostics.Process component and associates it with
        //     the component.
        //
        // Returns:
        //     true if a process resource is started; false if no new process resource is started
        //     (for example, if an existing process is reused).
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     No file name was specified in the System.Diagnostics.Process component's System.Diagnostics.Process.StartInfo.
        //     -or- The System.Diagnostics.ProcessStartInfo.UseShellExecute member of the System.Diagnostics.Process.StartInfo
        //     property is true while System.Diagnostics.ProcessStartInfo.RedirectStandardInput,
        //     System.Diagnostics.ProcessStartInfo.RedirectStandardOutput, or System.Diagnostics.ProcessStartInfo.RedirectStandardError
        //     is true.
        //
        //   T:System.ComponentModel.Win32Exception:
        //     There was an error in opening the associated file.
        //
        //   T:System.ObjectDisposedException:
        //     The process object has already been disposed.
        //
        //   T:System.PlatformNotSupportedException:
        //     Method not supported on operating systems without shell support such as Nano
        //     Server (.NET Core only).
        bool Start();
        //
        // Summary:
        //     Formats the process's name as a string, combined with the parent component type,
        //     if applicable.
        //
        // Returns:
        //     The System.Diagnostics.Process.ProcessName, combined with the base component's
        //     System.Object.ToString return value.
        string ToString();
        //
        // Summary:
        //     Instructs the System.Diagnostics.Process component to wait indefinitely for the
        //     associated process to exit.
        //
        // Exceptions:
        //   T:System.ComponentModel.Win32Exception:
        //     The wait setting could not be accessed.
        //
        //   T:System.SystemException:
        //     No process System.Diagnostics.Process.Id has been set, and a System.Diagnostics.Process.Handle
        //     from which the System.Diagnostics.Process.Id property can be determined does
        //     not exist. -or- There is no process associated with this System.Diagnostics.Process
        //     object. -or- You are attempting to call System.Diagnostics.Process.WaitForExit
        //     for a process that is running on a remote computer. This method is available
        //     only for processes that are running on the local computer.
        void WaitForExit();
        //
        // Summary:
        //     Instructs the System.Diagnostics.Process component to wait the specified number
        //     of milliseconds for the associated process to exit.
        //
        // Parameters:
        //   milliseconds:
        //     The amount of time, in milliseconds, to wait for the associated process to exit.
        //     The maximum is the largest possible value of a 32-bit integer, which represents
        //     infinity to the operating system.
        //
        // Returns:
        //     true if the associated process has exited; otherwise, false.
        //
        // Exceptions:
        //   T:System.ComponentModel.Win32Exception:
        //     The wait setting could not be accessed.
        //
        //   T:System.SystemException:
        //     No process System.Diagnostics.Process.Id has been set, and a System.Diagnostics.Process.Handle
        //     from which the System.Diagnostics.Process.Id property can be determined does
        //     not exist. -or- There is no process associated with this System.Diagnostics.Process
        //     object. -or- You are attempting to call System.Diagnostics.Process.WaitForExit(System.Int32)
        //     for a process that is running on a remote computer. This method is available
        //     only for processes that are running on the local computer.
        //
        //   T:System.ArgumentOutOfRangeException:
        //     milliseconds is a negative number other than -1, which represents an infinite
        //     time-out.
        bool WaitForExit(int milliseconds);
        //
        // Summary:
        //     Causes the System.Diagnostics.Process component to wait indefinitely for the
        //     associated process to enter an idle state. This overload applies only to processes
        //     with a user interface and, therefore, a message loop.
        //
        // Returns:
        //     true if the associated process has reached an idle state.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The process does not have a graphical interface. -or- An unknown error occurred.
        //     The process failed to enter an idle state. -or- The process has already exited.
        //     -or- No process is associated with this System.Diagnostics.Process object.
        bool WaitForInputIdle();
        //
        // Summary:
        //     Causes the System.Diagnostics.Process component to wait the specified number
        //     of milliseconds for the associated process to enter an idle state. This overload
        //     applies only to processes with a user interface and, therefore, a message loop.
        //
        // Parameters:
        //   milliseconds:
        //     A value of 1 to System.Int32.MaxValue that specifies the amount of time, in milliseconds,
        //     to wait for the associated process to become idle. A value of 0 specifies an
        //     immediate return, and a value of -1 specifies an infinite wait.
        //
        // Returns:
        //     true if the associated process has reached an idle state; otherwise, false.
        //
        // Exceptions:
        //   T:System.InvalidOperationException:
        //     The process does not have a graphical interface. -or- An unknown error occurred.
        //     The process failed to enter an idle state. -or- The process has already exited.
        //     -or- No process is associated with this System.Diagnostics.Process object.
        bool WaitForInputIdle(int milliseconds);

        //
        // Summary:
        //     Occurs when a process exits.
        event EventHandler Exited;
        //
        // Summary:
        //     Occurs when an application writes to its redirected System.Diagnostics.Process.StandardError
        //     stream.
        event DataReceivedEventHandler ErrorDataReceived;
        //
        // Summary:
        //     Occurs each time an application writes a line to its redirected System.Diagnostics.Process.StandardOutput
        //     stream.
        event DataReceivedEventHandler OutputDataReceived;

    }
}
