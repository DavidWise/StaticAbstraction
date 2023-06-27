using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace StaticAbstraction.Diagnostics
{


    public class StAbProcessInstance : IProcessInstance
    {
        //
        // Summary:
        //     Occurs when a process exits.
        public event EventHandler Exited;
        //
        // Summary:
        //     Occurs when an application writes to its redirected System.Diagnostics.Process.StandardError
        //     stream.
        public event DataReceivedEventHandler ErrorDataReceived;
        //
        // Summary:
        //     Occurs each time an application writes a line to its redirected System.Diagnostics.Process.StandardOutput
        //     stream.
        public event DataReceivedEventHandler OutputDataReceived;

        private Process _base;
        private bool disposedValue;

        public virtual ProcessPriorityClass PriorityClass {
            get => _base.PriorityClass;
            set => _base.PriorityClass = value;
        }
        
        public virtual bool PriorityBoostEnabled { 
            get => _base.PriorityBoostEnabled;
            set => _base.PriorityBoostEnabled = value;
        }

        public virtual long PeakWorkingSet64 => _base.PeakWorkingSet64;

        [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PeakWorkingSet64 instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual int PeakWorkingSet => _base.PeakWorkingSet;

        public virtual long PeakVirtualMemorySize64 => _base.PeakVirtualMemorySize64;

        [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PeakVirtualMemorySize64 instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual int PeakVirtualMemorySize => _base.PeakVirtualMemorySize;

        public virtual long PeakPagedMemorySize64 => _base.PeakPagedMemorySize64;

        [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PeakPagedMemorySize64 instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual int PeakPagedMemorySize => _base.PeakPagedMemorySize;

        public virtual long PagedSystemMemorySize64 => _base.PagedSystemMemorySize64;

        [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PagedSystemMemorySize64 instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual int PagedSystemMemorySize => _base.PagedSystemMemorySize;

        public virtual long PagedMemorySize64 => _base.PagedMemorySize64;

        [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PagedMemorySize64 instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual int PagedMemorySize => _base.PagedMemorySize;

        public virtual long NonpagedSystemMemorySize64 => _base.NonpagedSystemMemorySize64;

        [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.NonpagedSystemMemorySize64 instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual int NonpagedSystemMemorySize => _base.NonpagedSystemMemorySize;

        public virtual ProcessModuleCollection Modules => _base.Modules;

        public virtual IntPtr MinWorkingSet
        {
            get => _base.MinWorkingSet;
            set => _base.MinWorkingSet = value;
        }

        public virtual IntPtr MaxWorkingSet
        {
            get => _base.MaxWorkingSet;
            set => _base.MaxWorkingSet = value;
        }

        [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.PrivateMemorySize64 instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual int PrivateMemorySize => _base.PrivateMemorySize;

        public virtual long PrivateMemorySize64 => _base.PrivateMemorySize64;

        public virtual string MainWindowTitle => _base.MainWindowTitle;

        public virtual string ProcessName => _base.ProcessName;

        public virtual long WorkingSet64 => _base.WorkingSet64;

        [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.WorkingSet64 instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual int WorkingSet => _base.WorkingSet;

        public virtual long VirtualMemorySize64 => _base.VirtualMemorySize64;

        [Obsolete("This property has been deprecated.  Please use System.Diagnostics.Process.VirtualMemorySize64 instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual int VirtualMemorySize => _base.VirtualMemorySize;

        public virtual TimeSpan UserProcessorTime => _base.UserProcessorTime;

        public virtual TimeSpan TotalProcessorTime => _base.TotalProcessorTime;

        public virtual ProcessThreadCollection Threads => _base.Threads;

        public virtual ISynchronizeInvoke SynchronizingObject
        {
            get => _base.SynchronizingObject;
            set => _base.SynchronizingObject = value;
        }

        public virtual DateTime StartTime => _base.StartTime;

        public virtual ProcessStartInfo StartInfo
        {
            get => _base.StartInfo;
            set => _base.StartInfo = value;
        }

        public virtual StreamReader StandardOutput => _base.StandardOutput;
        public virtual StreamWriter StandardInput => _base.StandardInput;
        public virtual StreamReader StandardError => _base.StandardError;

        public virtual int SessionId => _base.SessionId;

#if !NET40 && !NET45
        public virtual SafeProcessHandle SafeHandle => _base.SafeHandle;
#endif

        public virtual bool Responding => _base.Responding;

        public virtual IntPtr ProcessorAffinity
        {
            get => _base.ProcessorAffinity;
            set => _base.ProcessorAffinity = value;
        }

        public virtual TimeSpan PrivilegedProcessorTime => _base.PrivilegedProcessorTime;

        public virtual ProcessModule MainModule => _base.MainModule;

        public virtual IntPtr MainWindowHandle => _base.MainWindowHandle;

        public virtual int Id => _base.Id;

        public virtual bool HasExited => _base.HasExited;

        public virtual int HandleCount => _base.HandleCount;

        public virtual IntPtr Handle => _base.Handle;

        public virtual DateTime ExitTime => _base.ExitTime;

        public virtual int ExitCode => _base.ExitCode;

        public virtual bool EnableRaisingEvents
        {
            get => _base.EnableRaisingEvents;
            set => _base.EnableRaisingEvents = value;
        }

        public virtual int BasePriority => _base.BasePriority;
        public virtual string MachineName => _base.MachineName;

        public virtual void BeginErrorReadLine() =>  _base.BeginErrorReadLine();
        public virtual void BeginOutputReadLine() => _base.BeginOutputReadLine();
        public virtual void CancelErrorRead() => _base.CancelErrorRead();
        public virtual void CancelOutputRead() => _base.CancelOutputRead();
        public virtual void Close() => _base.Close();
        public virtual void Kill() => _base.Kill();
#if NETCORE30 || NETCORE31 || NETCORE50 || NETCORE60 || NETCORE70
        public virtual void Kill(bool entireProcessTree) => _base.Kill(entireProcessTree);
#endif
        public virtual bool CloseMainWindow() => _base.CloseMainWindow();
        public virtual void Refresh() => _base.Refresh();
        public virtual bool Start() => _base.Start();
        public new string ToString() => _base.ToString();
        public virtual void WaitForExit() => _base.WaitForExit();
        public virtual bool WaitForExit(int milliseconds) => _base.WaitForExit(milliseconds);
        public virtual bool WaitForInputIdle() => _base.WaitForInputIdle();
        public virtual bool WaitForInputIdle(int milliseconds) => _base.WaitForInputIdle(milliseconds);

        protected virtual void OnExited()
        {
            
        }

        private void OnExitedEventHandler(object sender, EventArgs e)
        {
            if (this.Exited != null) this.Exited(sender, e);
            OnExited();
        }

        private void OnErrorDataReceivedEventHandler(object sender, DataReceivedEventArgs e)
        {
            if (this.ErrorDataReceived != null) this.ErrorDataReceived(sender, e);
        }

        private void OnOutputDataReceivedEventHandler(object sender, DataReceivedEventArgs e)
        {
            if (this.OutputDataReceived != null) this.OutputDataReceived(sender, e);
        }


        public StAbProcessInstance() : this(new Process())
        {

        }

        public StAbProcessInstance(Process instance)
        {
            _base = instance;
            _base.Exited += OnExitedEventHandler;
            _base.ErrorDataReceived += OnErrorDataReceivedEventHandler;
            _base.OutputDataReceived += OnOutputDataReceivedEventHandler;
        }

        public virtual ISite Site {
            get => _base.Site;
            set => _base.Site = value;
        }



#region Dispose()
        public event EventHandler Disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _base.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                _base = null;
                disposedValue = true;

                if (Disposed != null)
                {
                    Disposed(this, null);
                }
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~StAbProcessInstance()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public virtual void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

#endregion
    }
}
