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

#if NETCORE60
        [Obsolete("Assembly.ReflectionOnlyLoad(byte[])' is obsolete: 'ReflectionOnly loading is not supported and throws PlatformNotSupportedException.")]
#endif
        IAssemblyInstance ReflectionOnlyLoad(byte[] rawAssembly);

#if NETCORE60
        [Obsolete("Assembly.ReflectionOnlyLoad(string)' is obsolete: 'ReflectionOnly loading is not supported and throws PlatformNotSupportedException.")]
#endif
        IAssemblyInstance ReflectionOnlyLoad(string assemblyString);
#if NETCORE60
        [Obsolete("Assembly.ReflectionOnlyLoadFrom(string)' is obsolete: 'ReflectionOnly loading is not supported and throws PlatformNotSupportedException.")]
#endif
        IAssemblyInstance ReflectionOnlyLoadFrom(string assemblyFile);
        IAssemblyInstance UnsafeLoadFrom(string assemblyFile);
    }
}