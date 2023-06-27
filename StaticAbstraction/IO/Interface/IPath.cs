using System;

namespace StaticAbstraction.IO
{
    public interface IPath
    {
        char AltDirectorySeparatorChar { get; }
        char DirectorySeparatorChar { get; }
        char[] InvalidPathChars { get; }
        char PathSeparator { get; }
        char VolumeSeparatorChar { get; }


        string ChangeExtension(string path, string extension);
        string Combine(params string[] arguments);
        string GetDirectoryName(string path);
        string GetExtension(string path);
        string GetFileName(string path);

        string GetFileNameWithoutExtension(string path);
        string GetFullPath(string path);
        char[] GetInvalidFileNameChars();
        char[] GetInvalidPathChars();

        string GetPathRoot(string path);
        string GetRandomFileName();
        string GetTempFileName();
        string GetTempPath();

        bool HasExtension(string path);


        bool IsPathRooted(string path);




#if NETSTANDARD2_1 || NETCORE21 || NETCORE22
        string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2);
        string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3);

        ReadOnlySpan<char> GetDirectoryName(ReadOnlySpan<char> path);
        ReadOnlySpan<char> GetExtension(ReadOnlySpan<char> path);
        ReadOnlySpan<char> GetFileName(ReadOnlySpan<char> path);
        ReadOnlySpan<char> GetFileNameWithoutExtension(ReadOnlySpan<char> path);
        ReadOnlySpan<char> GetFullPath(string path, string basePath);
        ReadOnlySpan<char> GetPathRoot(ReadOnlySpan<char> path);
        string GetRelativePath(string relativeTo, string path);
        bool HasExtension(ReadOnlySpan<char> path);
        bool IsPathFullyQualified(string path);
        bool IsPathFullyQualified(ReadOnlySpan<char> path);
        bool IsPathRooted(ReadOnlySpan<char> path);

        bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, Span<char> destination, out int charsWritten);
        bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3, Span<char> destination, out int charsWritten);

        string Join(String path1, String path2);
        string Join(string path1, string path2, string path3);
#endif

#if NETCORE30  || NETCORE31 || NETCORE50 || NETCORE60 || NETCORE70
        bool EndsInDirectorySeparator(ReadOnlySpan<Char> path);
        bool EndsInDirectorySeparator(string path);
        string Join(String[] paths);
        string Join(ReadOnlySpan<Char> path1, ReadOnlySpan<Char> path2, ReadOnlySpan<Char> path3, ReadOnlySpan<Char> path4);
        string Join(string path1, string path2, string path3, string path4);
        string TrimEndingDirectorySeparator(string path);
        ReadOnlySpan<Char> TrimEndingDirectorySeparator(ReadOnlySpan<Char> path);
#endif
    }
}
