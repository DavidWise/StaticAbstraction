using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security;

namespace StaticAbstraction.Reflection.Mocks
{
    public class MockAssemblyInstance : IAssemblyInstance
    {
        public virtual string CodeBase { get; set; }

        public virtual MethodInfo EntryPoint { get; set; }

        public virtual string EscapedCodeBase { get; set; }

        public virtual string FullName { get; set; }

        public virtual bool GlobalAssemblyCache { get; set; }

        public virtual long HostContext { get; set; }

        public virtual string ImageRuntimeVersion { get; set; }

        public virtual bool IsDynamic { get; set; }

        public virtual bool IsFullyTrusted { get; set; }

        public virtual string Location { get; set; }

        public virtual Module ManifestModule { get; set; }

        public virtual bool ReflectionOnly { get; set; }

        public virtual SecurityRuleSet SecurityRuleSet { get; set; }

        public virtual object CreateInstance(string typeName)
        {
            return null;
        }

        public virtual object CreateInstance(string typeName, bool ignoreCase)
        {
            return null;
        }

        public virtual object CreateInstance(string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
        {
            return null;
        }

        public virtual object[] GetCustomAttributes(bool inherit)
        {
            return null;
        }

        public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            return null;
        }

        public virtual IList<CustomAttributeData> GetCustomAttributesData()
        {
            return null;
        }

        public virtual FileStream GetFile(string name)
        {
            return null;
        }

        public virtual FileStream[] GetFiles()
        {
            return null;
        }

        public virtual FileStream[] GetFiles(bool getResourceModules)
        {
            return null;
        }

        public virtual Module[] GetLoadedModules()
        {
            return null;
        }

        public virtual Module[] GetLoadedModules(bool getResourceModules)
        {
            return null;
        }

        public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName)
        {
            return null;
        }

        public virtual string[] GetManifestResourceNames()
        {
            return null;
        }

        public virtual Stream GetManifestResourceStream(string name)
        {
            return null;
        }

        public virtual Stream GetManifestResourceStream(Type type, string name)
        {
            return null;
        }

        public virtual Module GetModule(string name)
        {
            return null;
        }

        public virtual Module[] GetModules()
        {
            return null;
        }

        public virtual Module[] GetModules(bool getResourceModules)
        {
            return null;
        }

        public virtual AssemblyName GetName()
        {
            return null;
        }

        public virtual AssemblyName GetName(bool copiedName)
        {
            return null;
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
        }

        public virtual AssemblyName[] GetReferencedAssemblies()
        {
            return null;
        }

        public virtual IAssemblyInstance GetSatelliteAssembly(CultureInfo culture)
        {
            return null;
        }

        public virtual IAssemblyInstance GetSatelliteAssembly(CultureInfo culture, Version version)
        {
            return null;
        }

        public virtual Type GetType(string name)
        {
            return null;
        }

        public virtual Type GetType(string name, bool throwOnError)
        {
            return null;
        }

        public virtual Type GetType(string name, bool throwOnError, bool ignoreCase)
        {
            return null;
        }

        public virtual Type[] GetTypes()
        {
            return null;
        }

        public virtual bool IsDefined(Type attributeType, bool inherit)
        {
            return false;
        }

        public virtual Module LoadModule(string moduleName, byte[] rawModule)
        {
            return null;
        }

        public virtual Module LoadModule(string moduleName, byte[] rawModule, byte[] rawSymbolStore)
        {
            return null;
        }

#if !NET40
        public virtual IEnumerable<TypeInfo> DefinedTypes { get; set; }
        public virtual IEnumerable<CustomAttributeData> CustomAttributes { get; set; }
        public virtual IEnumerable<Type> ExportedTypes { get; set; }
        public virtual IEnumerable<Module> Modules { get; set; }
#endif

#if NETFULL
        public virtual System.Security.Policy.Evidence Evidence { get; set; }
        public virtual System.Security.PermissionSet PermissionSet { get; set; }
#endif

#if NETCORE22
        public virtual Type[] GetForwardedTypes()
        {
            return null;
        }
#endif
    }
}
