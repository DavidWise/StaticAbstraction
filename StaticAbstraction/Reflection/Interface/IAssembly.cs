using System.IO;

namespace StaticAbstraction.Reflection
{
    public interface IAssembly
    {
        string Location { get; }
        string CodeBase { get; }
        string[] GetManifestResourceNames();
        Stream GetManifestResourceStream(string name);
    }
}
