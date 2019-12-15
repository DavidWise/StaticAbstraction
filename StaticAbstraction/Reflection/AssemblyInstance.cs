using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;

namespace StaticAbstraction.Reflection
{

    public class StAbAssemblyInstance : IAssemblyInstance
    {
        protected Assembly WrappedObject { get; private set; }

        public StAbAssemblyInstance() { }

        public StAbAssemblyInstance(Assembly assembly)
        {
            WrappedObject = assembly;
        }

        public virtual string CodeBase => WrappedObject?.CodeBase;

        public virtual object CreateInstance(string typeName)
        {
            return WrappedObject.CreateInstance(typeName);
        }
        public virtual object CreateInstance(string typeName, bool ignoreCase)
        {
            return WrappedObject.CreateInstance(typeName, ignoreCase);
        }
        public virtual object CreateInstance(string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
        {
            return WrappedObject.CreateInstance(typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);
        }

       
        public virtual MethodInfo EntryPoint => WrappedObject?.EntryPoint;
        public virtual string EscapedCodeBase => WrappedObject?.EscapedCodeBase;
        public virtual string FullName => WrappedObject?.FullName;

        public virtual object[] GetCustomAttributes(bool inherit)
        {
            return WrappedObject?.GetCustomAttributes(inherit);
        }
        public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            return WrappedObject?.GetCustomAttributes(attributeType, inherit);
        }

        public virtual IList<CustomAttributeData> GetCustomAttributesData()
        {
            return WrappedObject?.GetCustomAttributesData();
        }

        public virtual Type[] GetExportedTypes()
        {
            return WrappedObject?.GetExportedTypes();
        }

        public virtual FileStream GetFile(string name)
        {
            return WrappedObject?.GetFile(name);
        }

        public virtual FileStream[] GetFiles()
        {
            return WrappedObject?.GetFiles();
        }
        public virtual FileStream[] GetFiles(bool getResourceModules)
        {
            return WrappedObject?.GetFiles(getResourceModules);
        }

        public override int GetHashCode()
        {
            return WrappedObject == null? 0 :WrappedObject.GetHashCode();
        }

        public virtual Module[] GetLoadedModules()
        {
            return WrappedObject?.GetLoadedModules();
        }
        public virtual Module[] GetLoadedModules(bool getResourceModules)
        {
            return WrappedObject?.GetLoadedModules(getResourceModules);
        }

        public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName)
        {
            return WrappedObject?.GetManifestResourceInfo(resourceName);
        }

        public virtual string[] GetManifestResourceNames()
        {
            return WrappedObject?.GetManifestResourceNames();
        }

        public virtual Stream GetManifestResourceStream(string name)
        {
            return WrappedObject?.GetManifestResourceStream(name);
        }
        public virtual Stream GetManifestResourceStream(Type type, string name)
        {
            return WrappedObject?.GetManifestResourceStream(type, name);
        }

        public virtual Module GetModule(string name)
        {
            return WrappedObject?.GetModule(name);
        }

        public virtual Module[] GetModules()
        {
            return WrappedObject?.GetModules();
        }
        public virtual Module[] GetModules(bool getResourceModules)
        {
            return WrappedObject?.GetModules(getResourceModules);
        }

        public virtual AssemblyName GetName()
        {
            return WrappedObject?.GetName();
        }
        public virtual AssemblyName GetName(bool copiedName)
        {
            return WrappedObject?.GetName(copiedName);
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            WrappedObject?.GetObjectData(info, context);
        }

        public virtual AssemblyName[] GetReferencedAssemblies()
        {
            return WrappedObject?.GetReferencedAssemblies();
        }

        public virtual IAssemblyInstance GetSatelliteAssembly(CultureInfo culture)
        {
            return WrappedObject?.GetSatelliteAssembly(culture).ToStaticAbstraction();
        }
        public virtual IAssemblyInstance GetSatelliteAssembly(CultureInfo culture, Version version)
        {
            return WrappedObject?.GetSatelliteAssembly(culture, version).ToStaticAbstraction();
        }

        public virtual Type GetType(string name)
        {
            return WrappedObject?.GetType(name);
        }
        public virtual Type GetType(string name, bool throwOnError)
        {
            return WrappedObject?.GetType(name, throwOnError);
        }
        public virtual Type GetType(string name, bool throwOnError, bool ignoreCase)
        {
            return WrappedObject?.GetType(name, throwOnError, ignoreCase);
        }

        public virtual Type[] GetTypes()
        {
            return WrappedObject?.GetTypes();
        }

        public virtual bool GlobalAssemblyCache => WrappedObject == null ? false : WrappedObject.GlobalAssemblyCache;
        public virtual long HostContext => WrappedObject == null ? 0 : WrappedObject.HostContext;
        public virtual string ImageRuntimeVersion => WrappedObject?.ImageRuntimeVersion;


        public virtual bool IsDefined(Type attributeType, bool inherit)
        {
            return WrappedObject == null ? false : WrappedObject.IsDefined(attributeType, inherit);
        }

        public virtual bool IsDynamic => WrappedObject == null ? false : WrappedObject.IsDynamic;
        public virtual bool IsFullyTrusted => WrappedObject == null ? false : WrappedObject.IsFullyTrusted;

        public virtual Module LoadModule(string moduleName, byte[] rawModule)
        {
            return WrappedObject.LoadModule(moduleName, rawModule);
        }
        public virtual Module LoadModule(string moduleName, byte[] rawModule, byte[] rawSymbolStore)
        {
            return WrappedObject.LoadModule(moduleName, rawModule, rawSymbolStore);
        }

        public virtual string Location => WrappedObject?.Location;
        public virtual Module ManifestModule => WrappedObject?.ManifestModule;

        // TODO: Need to figure out how to handle these in the wrappers
        // public virtual event ModuleResolveEventHandler ModuleResolve;


        public virtual bool ReflectionOnly => WrappedObject == null ? false : WrappedObject.ReflectionOnly;
        public virtual System.Security.SecurityRuleSet SecurityRuleSet => WrappedObject==null ? System.Security.SecurityRuleSet.None : WrappedObject.SecurityRuleSet;

        public override string ToString()
        {
            return WrappedObject?.ToString();
        }

#if !NET40
        public virtual IEnumerable<TypeInfo> DefinedTypes => WrappedObject?.DefinedTypes;
        public virtual IEnumerable<CustomAttributeData> CustomAttributes => WrappedObject?.CustomAttributes;
        public virtual IEnumerable<Type> ExportedTypes => WrappedObject?.ExportedTypes;
        public virtual IEnumerable<Module> Modules => WrappedObject?.Modules;

#endif

#if NETFULL
        public virtual System.Security.Policy.Evidence Evidence => WrappedObject?.Evidence;
        public virtual System.Security.PermissionSet PermissionSet => WrappedObject?.PermissionSet;
#endif

#if NETSTANDARD2_1 || NETCORE21 || NETCORE22 || NETCORE30
        public virtual Type[] GetForwardedTypes()
        {
            return WrappedObject?.GetForwardedTypes();
        }
#endif
#if NETCORE30
        public virtual bool IsCollectible => WrappedObject == null ? false : WrappedObject.IsCollectible;
#endif
    }
}
