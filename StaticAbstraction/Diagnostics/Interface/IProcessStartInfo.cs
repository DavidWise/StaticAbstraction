using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Security;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace StaticAbstraction.Diagnostics.Interface
{
    public interface IProcessStartInfo
    {
        string[] Verbs { get; }
        string Verb { get; set; }
        bool UseShellExecute { get; set; }
        string UserName { get; set; }
        Encoding StandardOutputEncoding { get; set; }

#if NETCOREAPP2_1_OR_GREATER
        Encoding StandardInputEncoding { get; set; }
        Collection<string> ArgumentList { get; }
#endif 
        Encoding StandardErrorEncoding { get; set; }

        bool RedirectStandardOutput { get; set; }
        bool RedirectStandardInput { get; set; }
        bool RedirectStandardError { get; set; }

#if NET47_OR_GREATER || NETCOREAPP
        string PasswordInClearText { get; set; }
#endif
        SecureString Password { get; set; }
        bool LoadUserProfile { get; set; }
        string FileName { get; set; }
        IntPtr ErrorDialogParentHandle { get; set; }
        bool ErrorDialog { get; set; }
        StringDictionary EnvironmentVariables { get; }
#if !NET40 && !NET45
        IDictionary<string, string> Environment { get; }
#endif
        string Domain { get; set; }
        bool CreateNoWindow { get; set; }
        string Arguments { get; set; }
        ProcessWindowStyle WindowStyle { get; set; }
        string WorkingDirectory { get; set; }
    }
}
