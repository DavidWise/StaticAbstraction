using System;
using System.Reflection;

namespace StaticAbstraction.Reflection
{

    public class StAbAssembly : IAssembly
    {
        public string CreateQualifiedName(string assemblyName, string typeName)
        {
            return Assembly.CreateQualifiedName(assemblyName, typeName);
        }

        public IAssemblyInstance GetAssembly(Type type)
        {
            return Assembly.GetAssembly(type).ToStaticAbstraction();
        }
        public IAssemblyInstance GetCallingAssembly()
        {
            return Assembly.GetCallingAssembly().ToStaticAbstraction();
        }
        public IAssemblyInstance GetEntryAssembly()
        {
            return Assembly.GetEntryAssembly().ToStaticAbstraction();
        }
        public IAssemblyInstance GetExecutingAssembly()
        {
            return Assembly.GetExecutingAssembly().ToStaticAbstraction();
        }

        public IAssemblyInstance Load(AssemblyName assemblyRef)
        {
            return Assembly.Load(assemblyRef).ToStaticAbstraction();
        }
        public IAssemblyInstance Load(string assemblyString)
        {
            return Assembly.Load(assemblyString).ToStaticAbstraction();
        }
        public IAssemblyInstance Load(byte[] rawAssembly)
        {
            return Assembly.Load(rawAssembly).ToStaticAbstraction();
        }
        public IAssemblyInstance Load(byte[] rawAssembly, byte[] rawSymbolStore)
        {
            return Assembly.Load(rawAssembly, rawSymbolStore).ToStaticAbstraction();
        }

        public IAssemblyInstance LoadFile(string path)
        {
            return Assembly.LoadFile(path).ToStaticAbstraction();
        }

        public IAssemblyInstance LoadFrom(string assemblyFile)
        {
            return Assembly.LoadFrom(assemblyFile).ToStaticAbstraction();
        }
        public IAssemblyInstance LoadFrom(string assemblyFile, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm)
        {
            return Assembly.LoadFrom(assemblyFile, hashValue, hashAlgorithm).ToStaticAbstraction();
        }

        [Obsolete]
        public IAssemblyInstance LoadWithPartialName(string partialName)
        {
            return Assembly.LoadWithPartialName(partialName).ToStaticAbstraction();
        }

        public IAssemblyInstance ReflectionOnlyLoad(string assemblyString)
        {
            return Assembly.ReflectionOnlyLoad(assemblyString).ToStaticAbstraction();
        }
        public IAssemblyInstance ReflectionOnlyLoad(byte[] rawAssembly)
        {
            return Assembly.ReflectionOnlyLoad(rawAssembly).ToStaticAbstraction();
        }

        public IAssemblyInstance ReflectionOnlyLoadFrom(string assemblyFile)
        {
            return Assembly.ReflectionOnlyLoadFrom(assemblyFile).ToStaticAbstraction();
        }

        public IAssemblyInstance UnsafeLoadFrom(string assemblyFile)
        {
            return Assembly.UnsafeLoadFrom(assemblyFile).ToStaticAbstraction();
        }
    }
}
