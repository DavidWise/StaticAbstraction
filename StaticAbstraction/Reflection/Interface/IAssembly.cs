using System;
using System.Reflection;

namespace StaticAbstraction.Reflection
{
    public interface IAssembly
    {
        string CreateQualifiedName(string assemblyName, string typeName);
        IAssemblyInstance GetAssembly(Type type);
        IAssemblyInstance GetCallingAssembly();
        IAssemblyInstance GetEntryAssembly();
        IAssemblyInstance GetExecutingAssembly();
        IAssemblyInstance Load(AssemblyName assemblyRef);
        IAssemblyInstance Load(byte[] rawAssembly);
        IAssemblyInstance Load(byte[] rawAssembly, byte[] rawSymbolStore);
        IAssemblyInstance Load(string assemblyString);
        IAssemblyInstance LoadFile(string path);
        IAssemblyInstance LoadFrom(string assemblyFile);
        IAssemblyInstance LoadFrom(string assemblyFile, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm);
        IAssemblyInstance LoadWithPartialName(string partialName);
        IAssemblyInstance ReflectionOnlyLoad(byte[] rawAssembly);
        IAssemblyInstance ReflectionOnlyLoad(string assemblyString);
        IAssemblyInstance ReflectionOnlyLoadFrom(string assemblyFile);
        IAssemblyInstance UnsafeLoadFrom(string assemblyFile);
    }
}