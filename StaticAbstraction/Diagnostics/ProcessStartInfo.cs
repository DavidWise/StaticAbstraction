using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Security;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace StaticAbstraction.Diagnostics
{
    public interface IProcessStartInfo
    {
        string[] Verbs { get; }
        string Verb { get; set; }
        bool UseShellExecute { get; set; }
        string UserName { get; set; }
        Encoding StandardOutputEncoding { get; set; }

#if NETCORE21 || NETCORE22 || NETSTANDARD21 || NETCORE30 || NETCORE31 || NETCORE50 || NETCORE60
        Encoding StandardInputEncoding { get; set; }
        Collection<string> ArgumentList { get; }
#endif 
        Encoding StandardErrorEncoding { get; set; }

        bool RedirectStandardOutput { get; set; }
        bool RedirectStandardInput { get; set; }
        bool RedirectStandardError { get; set; }
#if NET47 || NET48 || NETCORE
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


    public class StAbProcessStartInfo : IProcessStartInfo
    {
        private ProcessStartInfo _base;

        public StAbProcessStartInfo()
        {
            _base = new ProcessStartInfo();
        }

        public StAbProcessStartInfo(string filename)
        {
            _base = new ProcessStartInfo(filename);
        }

        public StAbProcessStartInfo(string filename, string arguments)
        {
            _base = new ProcessStartInfo(filename, arguments);
        }

        public virtual string[] Verbs => _base.Verbs;

        public virtual string Verb { 
            get => _base.Verb;
            set => _base.Verb = value; 
        }

        public virtual string UserName
        {
            get => _base.UserName;
            set => _base.UserName = value;
        }

        public virtual bool UseShellExecute {
            get => _base.UseShellExecute;
            set => _base.UseShellExecute = value; 
        }

        public virtual Encoding StandardOutputEncoding
        {
            get => _base.StandardOutputEncoding;
            set => _base.StandardOutputEncoding = value;
        }

#if NETCORE21 || NETCORE22 || NETSTANDARD21 || NETCORE30 || NETCORE31 || NETCORE50 || NETCORE60
        public virtual Encoding StandardInputEncoding
        {
            get => _base.StandardInputEncoding;
            set => _base.StandardInputEncoding = value;
        }

        public virtual Collection<string> ArgumentList => _base.ArgumentList;
#endif

        public virtual Encoding StandardErrorEncoding
        {
            get => _base.StandardErrorEncoding;
            set => _base.StandardErrorEncoding = value;
        }

        public virtual bool RedirectStandardOutput
        {
            get => _base.RedirectStandardOutput;
            set => _base.RedirectStandardOutput = value;
        }
        public virtual bool RedirectStandardInput
        {
            get => _base.RedirectStandardInput;
            set => _base.RedirectStandardInput = value;
        }

        public virtual bool RedirectStandardError
        {
            get => _base.RedirectStandardError;
            set => _base.RedirectStandardError = value;
        }

#if NET47 || NET48 || NETCORE
        public virtual string PasswordInClearText
        {
            get => _base.PasswordInClearText;
            set => _base.PasswordInClearText = value;
        }
#endif

        public virtual SecureString Password
        {
            get => _base.Password;
            set => _base.Password = value;
        }

        public virtual bool LoadUserProfile
        {
            get => _base.LoadUserProfile;
            set => _base.LoadUserProfile = value;
        }

        public virtual string FileName
        {
            get => _base.FileName;
            set => _base.FileName = value;
        }

        public virtual IntPtr ErrorDialogParentHandle
        {
            get => _base.ErrorDialogParentHandle;
            set => _base.ErrorDialogParentHandle = value;
        }

        public virtual bool ErrorDialog
        {
            get => _base.ErrorDialog;
            set => _base.ErrorDialog = value;
        }

        public virtual StringDictionary EnvironmentVariables => _base.EnvironmentVariables;

#if !NET40 && !NET45
        public virtual IDictionary<string, string> Environment => _base.Environment;
#endif
        public virtual string Domain
        {
            get => _base.Domain;
            set => _base.Domain = value;
        }

        public virtual bool CreateNoWindow
        {
            get => _base.CreateNoWindow;
            set => _base.CreateNoWindow = value;
        }

        public virtual string Arguments
        {
            get => _base.Arguments;
            set => _base.Arguments = value;
        }

        public virtual ProcessWindowStyle WindowStyle
        {
            get => _base.WindowStyle;
            set => _base.WindowStyle = value;
        }

        public virtual string WorkingDirectory
        {
            get => _base.WorkingDirectory;
            set => _base.WorkingDirectory = value;
        }
    }

    internal static class IProcessStartInfoExtensions
    {
        public static ProcessStartInfo ToNativeObject(this IProcessStartInfo info)
        {
            if (info == null) return null;

            var result = new ProcessStartInfo(info.FileName, info.Arguments)
            {
                Verb = info.Verb,
                UseShellExecute = info.UseShellExecute,
                UserName = info.UserName,
                StandardOutputEncoding = info.StandardOutputEncoding,
#if NETCORE21 || NETCORE22 || NETSTANDARD21 || NETCORE30 || NETCORE31 || NETCORE50 || NETCORE60
                StandardInputEncoding = info.StandardInputEncoding,
#endif
                StandardErrorEncoding = info.StandardErrorEncoding,
                RedirectStandardOutput = info.RedirectStandardOutput,
                RedirectStandardInput = info.RedirectStandardInput,
                RedirectStandardError = info.RedirectStandardError,
#if NET47 || NET48 || NETCORE
                PasswordInClearText = info.PasswordInClearText,
#endif
                Password = info.Password,
                LoadUserProfile = info.LoadUserProfile,
                ErrorDialogParentHandle = info.ErrorDialogParentHandle,
                ErrorDialog = info.ErrorDialog,
                Domain = info.Domain,
                CreateNoWindow = info.CreateNoWindow,
                WindowStyle = info.WindowStyle,
                WorkingDirectory = info.WorkingDirectory
            };

            return result;
        }
    }
}
