using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security;
using System.Text;
using StaticAbstraction.Diagnostics.Interface;
using System.Threading.Tasks;


namespace StaticAbstraction.Diagnostics
{

#if NET40_OR_GREATER || NETCOREAPP3_0_OR_GREATER
    public class StAbProcess : IProcess
    {
        public virtual void EnterDebugMode()
        {
            Process.EnterDebugMode();
        }

        public virtual void LeaveDebugMode()
        {
            Process.LeaveDebugMode();
        }

        public virtual IProcessInstance GetCurrentProcess()
        {
            var proc = Process.GetCurrentProcess();
            return BuildNewInstance(proc);
        }

        public virtual IProcessInstance GetProcessById(int processId, string machineName)
        {
            var proc = Process.GetProcessById(processId, machineName);
            return BuildNewInstance(proc);
        }

        public virtual IProcessInstance GetProcessById(int processId)
        {
            var proc = Process.GetProcessById(processId);
            return BuildNewInstance(proc);
        }

        public virtual IProcessInstance[] GetProcesses()
        {
            var procs = Process.GetProcesses();
            return BuildNewInstances(procs);
        }

        public virtual IProcessInstance[] GetProcesses(string machineName)
        {
            var procs = Process.GetProcesses(machineName);
            return BuildNewInstances(procs);
        }

        public virtual IProcessInstance[] GetProcessesByName(string processName)
        {
            var procs = Process.GetProcessesByName(processName);
            return BuildNewInstances(procs);
        }


        public virtual IProcessInstance[] GetProcessesByName(string processName, string machineName)
        {
            var procs = Process.GetProcessesByName(processName, machineName);
            return BuildNewInstances(procs);
        }

        public virtual IProcessInstance Start(string fileName)
        {
            var proc = Process.Start(fileName);
            return BuildNewInstance(proc);
        }

        public virtual IProcessInstance Start(ProcessStartInfo startInfo)
        {
            var proc = Process.Start(startInfo);
            return BuildNewInstance(proc);
        }

        public virtual IProcessInstance Start(IProcessStartInfo startInfo)
        {
            var info = startInfo.ToNativeObject();
            var proc = Process.Start(info);
            return BuildNewInstance(proc);
        }

        public virtual IProcessInstance Start(string fileName, string arguments)
        {
            var proc = Process.Start(fileName, arguments);
            return BuildNewInstance(proc);
        }

#if NET5_0_OR_GREATER
        public virtual IProcessInstance Start(String fileName, IEnumerable<String> arguments)
        {
            var proc = Process.Start(fileName, arguments);
            return BuildNewInstance(proc);
        }
#endif

        public virtual IProcessInstance Start(string fileName, string userName, SecureString password, string domain)
        {
            var proc = Process.Start(fileName, userName, password, domain);
            return BuildNewInstance(proc);
        }

        public virtual IProcessInstance Start(string fileName, string arguments, string userName, SecureString password, string domain)
        {
            var proc = Process.Start(fileName, arguments, userName, password, domain);
            return BuildNewInstance(proc);
        }

        #region helpers
        protected static IProcessInstance[] BuildNewInstances(Process[] procs)
        {
            if (procs == null || procs.Length < 1) return new IProcessInstance[0];

            var result = new IProcessInstance[procs.Length];

            for (var i = 0; i < procs.Length; i++)
                result[i] = BuildNewInstance(procs[i]);

            return result;
        }


        protected static IProcessInstance BuildNewInstance(Process proc)
        {
            if (proc == null) return null;
            return new StAbProcessInstance(proc);
        }

        #endregion
    }
#endif
}
