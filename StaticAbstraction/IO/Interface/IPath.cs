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
        ReadOnlySpan<char> GetDirectoryName(ReadOnlySpan<char> path);
        string GetExtension(string path);
        ReadOnlySpan<char> GetExtension(ReadOnlySpan<char> path);
        string GetFileName(string path);
        ReadOnlySpan<char> GetFileName(ReadOnlySpan<char> path);

        string GetFileNameWithoutExtension(string path);
        ReadOnlySpan<char> GetFileNameWithoutExtension(ReadOnlySpan<char> path);
        string GetFullPath(string path);
        ReadOnlySpan<char> GetFullPath(string path, string basePath);
        char[] GetInvalidFileNameChars();
        char[] GetInvalidPathChars();

        string GetPathRoot(string path);
        ReadOnlySpan<char> GetPathRoot(ReadOnlySpan<char> path);
        string GetRandomFileName();
        string GetRelativePath(string relativeTo, string path);
        string GetTempFileName();
        string GetTempPath();

        bool HasExtension(string path);
        bool HasExtension(ReadOnlySpan<char> path);

        bool IsPathFullyQualified(string path);
        bool IsPathFullyQualified(ReadOnlySpan<char> path);

        bool IsPathRooted(string path);
        bool IsPathRooted(ReadOnlySpan<char> path);

        string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2);
        string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3);

        bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, Span<char> destination, out int charsWritten);
        bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3, Span<char> destination, out int charsWritten);
    }
}
