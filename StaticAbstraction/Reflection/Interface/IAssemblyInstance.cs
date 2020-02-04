using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;

namespace StaticAbstraction.Reflection
{
    public interface IAssemblyInstance
    {
        string CodeBase { get; }
        MethodInfo EntryPoint { get; }
        string EscapedCodeBase { get; }
        string FullName { get; }
        bool GlobalAssemblyCache { get; }
        long HostContext { get; }
        string ImageRuntimeVersion { get; }
        bool IsDynamic { get; }
#if NETCORE30 || NETCORE31
        bool IsCollectible { get; }
#endif
        bool IsFullyTrusted { get; }
        string Location { get; }
        Module ManifestModule { get; }
        bool ReflectionOnly { get; }
        SecurityRuleSet SecurityRuleSet { get; }

        object CreateInstance(string typeName);
        object CreateInstance(string typeName, bool ignoreCase);

        object CreateInstance(string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes);
        object[] GetCustomAttributes(bool inherit);
        object[] GetCustomAttributes(Type attributeType, bool inherit);
        IList<CustomAttributeData> GetCustomAttributesData();
        FileStream GetFile(string name);
        FileStream[] GetFiles();
        FileStream[] GetFiles(bool getResourceModules);
        int GetHashCode();
        Module[] GetLoadedModules();
        Module[] GetLoadedModules(bool getResourceModules);
        ManifestResourceInfo GetManifestResourceInfo(string resourceName);
        string[] GetManifestResourceNames();
        Stream GetManifestResourceStream(string name);
        Stream GetManifestResourceStream(Type type, string name);
        Module GetModule(string name);
        Module[] GetModules();
        Module[] GetModules(bool getResourceModules);
        AssemblyName GetName();
        AssemblyName GetName(bool copiedName);
        void GetObjectData(SerializationInfo info, StreamingContext context);
        AssemblyName[] GetReferencedAssemblies();
        IAssemblyInstance GetSatelliteAssembly(CultureInfo culture);
        IAssemblyInstance GetSatelliteAssembly(CultureInfo culture, Version version);
        Type GetType(string name);
        Type GetType(string name, bool throwOnError);
        Type GetType(string name, bool throwOnError, bool ignoreCase);
        Type[] GetTypes();
        bool IsDefined(Type attributeType, bool inherit);
        Module LoadModule(string moduleName, byte[] rawModule);
        Module LoadModule(string moduleName, byte[] rawModule, byte[] rawSymbolStore);
        string ToString();

#if !NET40
        IEnumerable<TypeInfo> DefinedTypes { get; }
        IEnumerable<CustomAttributeData> CustomAttributes { get; }
        IEnumerable<Type> ExportedTypes { get; }
        IEnumerable<Module> Modules { get; }
#endif

#if NETFULL
        System.Security.Policy.Evidence Evidence { get; }
        System.Security.PermissionSet PermissionSet { get; }
#endif

#if NETSTANDARD2_1 || NETCORE21 || NETCORE22 || NETCORE30 || NETCORE31
        Type[] GetForwardedTypes();
#endif
    }
}