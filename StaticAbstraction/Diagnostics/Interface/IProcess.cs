using System.Diagnostics;
using System.Security;

namespace StaticAbstraction.Diagnostics.Interface
{
#if NET40_OR_GREATER || NETCOREAPP3_0_OR_GREATER
    public interface IProcess
    {
        void EnterDebugMode();
        void LeaveDebugMode();
        IProcessInstance GetCurrentProcess();
        IProcessInstance GetProcessById(int processId, string machineName);
        IProcessInstance GetProcessById(int processId);
        IProcessInstance[] GetProcesses();
        IProcessInstance[] GetProcesses(string machineName);
        IProcessInstance[] GetProcessesByName(string processName);
        IProcessInstance[] GetProcessesByName(string processName, string machineName);
        IProcessInstance Start(string fileName);
        IProcessInstance Start(ProcessStartInfo startInfo);
        IProcessInstance Start(IProcessStartInfo startInfo);
        IProcessInstance Start(string fileName, string arguments);
        IProcessInstance Start(string fileName, string userName, SecureString password, string domain);
        IProcessInstance Start(string fileName, string arguments, string userName, SecureString password, string domain);
    }
#endif
}
