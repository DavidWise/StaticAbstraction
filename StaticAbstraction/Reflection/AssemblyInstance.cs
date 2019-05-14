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
        protected Assembly _assembly;

        public StAbAssemblyInstance() { }

        public StAbAssemblyInstance(Assembly assembly)
        {
            _assembly = assembly;
        }

        public string CodeBase => _assembly?.CodeBase;

        public object CreateInstance(string typeName)
        {
            return _assembly.CreateInstance(typeName);
        }
        public object CreateInstance(string typeName, bool ignoreCase)
        {
            return _assembly.CreateInstance(typeName, ignoreCase);
        }
        public object CreateInstance(string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
        {
            return _assembly.CreateInstance(typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);
        }

       
        public MethodInfo EntryPoint => _assembly?.EntryPoint;
        public string EscapedCodeBase => _assembly?.EscapedCodeBase;
        public string FullName => _assembly?.FullName;

        public object[] GetCustomAttributes(bool inherit)
        {
            return _assembly?.GetCustomAttributes(inherit);
        }
        public object[] GetCustomAttributes(Type attributeType, bool inherit)
        {
            return _assembly?.GetCustomAttributes(attributeType, inherit);
        }

        public IList<CustomAttributeData> GetCustomAttributesData()
        {
            return _assembly?.GetCustomAttributesData();
        }

        public Type[] GetExportedTypes()
        {
            return _assembly?.GetExportedTypes();
        }

        public FileStream GetFile(string name)
        {
            return _assembly?.GetFile(name);
        }

        public FileStream[] GetFiles()
        {
            return _assembly?.GetFiles();
        }
        public FileStream[] GetFiles(bool getResourceModules)
        {
            return _assembly?.GetFiles(getResourceModules);
        }

        public override int GetHashCode()
        {
            return _assembly == null? 0 :_assembly.GetHashCode();
        }

        public Module[] GetLoadedModules()
        {
            return _assembly?.GetLoadedModules();
        }
        public Module[] GetLoadedModules(bool getResourceModules)
        {
            return _assembly?.GetLoadedModules(getResourceModules);
        }

        public ManifestResourceInfo GetManifestResourceInfo(string resourceName)
        {
            return _assembly?.GetManifestResourceInfo(resourceName);
        }

        public string[] GetManifestResourceNames()
        {
            return _assembly?.GetManifestResourceNames();
        }

        public Stream GetManifestResourceStream(string name)
        {
            return _assembly?.GetManifestResourceStream(name);
        }
        public Stream GetManifestResourceStream(Type type, string name)
        {
            return _assembly?.GetManifestResourceStream(type, name);
        }

        public Module GetModule(string name)
        {
            return _assembly?.GetModule(name);
        }

        public Module[] GetModules()
        {
            return _assembly?.GetModules();
        }
        public Module[] GetModules(bool getResourceModules)
        {
            return _assembly?.GetModules(getResourceModules);
        }

        public AssemblyName GetName()
        {
            return _assembly?.GetName();
        }
        public AssemblyName GetName(bool copiedName)
        {
            return _assembly?.GetName(copiedName);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            _assembly?.GetObjectData(info, context);
        }

        public AssemblyName[] GetReferencedAssemblies()
        {
            return _assembly?.GetReferencedAssemblies();
        }

        public IAssemblyInstance GetSatelliteAssembly(CultureInfo culture)
        {
            return _assembly?.GetSatelliteAssembly(culture).ToStaticAbstraction();
        }
        public IAssemblyInstance GetSatelliteAssembly(CultureInfo culture, Version version)
        {
            return _assembly?.GetSatelliteAssembly(culture, version).ToStaticAbstraction();
        }

        public Type GetType(string name)
        {
            return _assembly?.GetType(name);
        }
        public Type GetType(string name, bool throwOnError)
        {
            return _assembly?.GetType(name, throwOnError);
        }
        public Type GetType(string name, bool throwOnError, bool ignoreCase)
        {
            return _assembly?.GetType(name, throwOnError, ignoreCase);
        }

        public Type[] GetTypes()
        {
            return _assembly?.GetTypes();
        }

        public bool GlobalAssemblyCache => _assembly == null ? false : _assembly.GlobalAssemblyCache;
        public long HostContext => _assembly == null ? 0 : _assembly.HostContext;
        public string ImageRuntimeVersion => _assembly?.ImageRuntimeVersion;


        public bool IsDefined(Type attributeType, bool inherit)
        {
            return _assembly == null ? false : _assembly.IsDefined(attributeType, inherit);
        }

        public bool IsDynamic => _assembly == null ? false : _assembly.IsDynamic;
        public bool IsFullyTrusted => _assembly == null ? false : _assembly.IsFullyTrusted;

        public Module LoadModule(string moduleName, byte[] rawModule)
        {
            return _assembly.LoadModule(moduleName, rawModule);
        }
        public Module LoadModule(string moduleName, byte[] rawModule, byte[] rawSymbolStore)
        {
            return _assembly.LoadModule(moduleName, rawModule, rawSymbolStore);
        }

        public string Location => _assembly?.Location;
        public Module ManifestModule => _assembly?.ManifestModule;

        // TODO: Need to figure out how to handle these in the wrappers
        // public event ModuleResolveEventHandler ModuleResolve;


        public bool ReflectionOnly => _assembly == null ? false : _assembly.ReflectionOnly;
        public System.Security.SecurityRuleSet SecurityRuleSet => _assembly==null ? System.Security.SecurityRuleSet.None : _assembly.SecurityRuleSet;

        public override string ToString()
        {
            return _assembly?.ToString();
        }

#if !NET40
        public IEnumerable<TypeInfo> DefinedTypes => _assembly?.DefinedTypes;
        public IEnumerable<CustomAttributeData> CustomAttributes => _assembly?.CustomAttributes;
        public IEnumerable<Type> ExportedTypes => _assembly?.ExportedTypes;
        public IEnumerable<Module> Modules => _assembly?.Modules;
#endif

#if NETFULL
        public System.Security.Policy.Evidence Evidence => _assembly?.Evidence;
        public System.Security.PermissionSet PermissionSet => _assembly?.PermissionSet;
#endif

#if NETCORE22
        public Type[] GetForwardedTypes()
        {
            return _assembly?.GetForwardedTypes();
        }
#endif
    }
}
