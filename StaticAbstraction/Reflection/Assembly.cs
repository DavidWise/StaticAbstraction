using System;
using System.Reflection;

namespace StaticAbstraction.Reflection
{

    public class StAbAssembly : IAssembly
    {
        public virtual string CreateQualifiedName(string assemblyName, string typeName)
        {
            return Assembly.CreateQualifiedName(assemblyName, typeName);
        }

        public virtual IAssemblyInstance GetAssembly(Type type)
        {
            return Assembly.GetAssembly(type).ToStaticAbstraction();
        }
        public virtual IAssemblyInstance GetCallingAssembly()
        {
            return Assembly.GetCallingAssembly().ToStaticAbstraction();
        }
        public virtual IAssemblyInstance GetEntryAssembly()
        {
            return Assembly.GetEntryAssembly().ToStaticAbstraction();
        }
        public virtual IAssemblyInstance GetExecutingAssembly()
        {
            return Assembly.GetExecutingAssembly().ToStaticAbstraction();
        }

        public virtual IAssemblyInstance Load(AssemblyName assemblyRef)
        {
            return Assembly.Load(assemblyRef).ToStaticAbstraction();
        }
        public virtual IAssemblyInstance Load(string assemblyString)
        {
            return Assembly.Load(assemblyString).ToStaticAbstraction();
        }
        public virtual IAssemblyInstance Load(byte[] rawAssembly)
        {
            return Assembly.Load(rawAssembly).ToStaticAbstraction();
        }
        public virtual IAssemblyInstance Load(byte[] rawAssembly, byte[] rawSymbolStore)
        {
            return Assembly.Load(rawAssembly, rawSymbolStore).ToStaticAbstraction();
        }

        public virtual IAssemblyInstance LoadFile(string path)
        {
            return Assembly.LoadFile(path).ToStaticAbstraction();
        }

        public virtual IAssemblyInstance LoadFrom(string assemblyFile)
        {
            return Assembly.LoadFrom(assemblyFile).ToStaticAbstraction();
        }
        public virtual IAssemblyInstance LoadFrom(string assemblyFile, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm)
        {
            return Assembly.LoadFrom(assemblyFile, hashValue, hashAlgorithm).ToStaticAbstraction();
        }

        [Obsolete]
        public virtual IAssemblyInstance LoadWithPartialName(string partialName)
        {
            return Assembly.LoadWithPartialName(partialName).ToStaticAbstraction();
        }

        public virtual IAssemblyInstance ReflectionOnlyLoad(string assemblyString)
        {
            return Assembly.ReflectionOnlyLoad(assemblyString).ToStaticAbstraction();
        }
        public virtual IAssemblyInstance ReflectionOnlyLoad(byte[] rawAssembly)
        {
            return Assembly.ReflectionOnlyLoad(rawAssembly).ToStaticAbstraction();
        }

        public virtual IAssemblyInstance ReflectionOnlyLoadFrom(string assemblyFile)
        {
            return Assembly.ReflectionOnlyLoadFrom(assemblyFile).ToStaticAbstraction();
        }

        public virtual IAssemblyInstance UnsafeLoadFrom(string assemblyFile)
        {
            return Assembly.UnsafeLoadFrom(assemblyFile).ToStaticAbstraction();
        }
    }
}
