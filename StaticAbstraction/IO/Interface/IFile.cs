namespace StaticAbstraction.IO
{
    public interface IFile
    {
        bool Exists(string path);
        string ReadAllText(string path);
        string[] ReadAllLines(string path);
        void WriteAllText(string path, string contents);

    }
}
