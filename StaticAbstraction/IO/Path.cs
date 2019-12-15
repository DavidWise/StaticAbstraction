using System;
using System.IO;

namespace StaticAbstraction.IO
{
    public class StAbPath : IPath
    {
        public virtual char AltDirectorySeparatorChar => Path.AltDirectorySeparatorChar;
        public virtual char DirectorySeparatorChar => Path.DirectorySeparatorChar;
        [Obsolete("Please use GetInvalidPathChars or GetInvalidFileNameChars instead.")]
        public virtual char[] InvalidPathChars => Path.InvalidPathChars;
        public virtual char PathSeparator => Path.PathSeparator;
        public virtual char VolumeSeparatorChar => Path.VolumeSeparatorChar;

        public virtual string ChangeExtension(string path, string extension)
        {
            return Path.ChangeExtension(path, extension);
        }

        public virtual string Combine(params string[] paths)
        {
            return Path.Combine(paths);
        }

        public virtual string GetDirectoryName(string path)
        {
            return Path.GetDirectoryName(path);
        }


        public virtual string GetExtension(string path)
        {
            return Path.GetExtension(path);
        }


        public virtual string GetFileName(string path)
        {
            return Path.GetFileName(path);
        }


        public virtual string GetFileNameWithoutExtension(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }


        public virtual string GetFullPath(string path)
        {
            return Path.GetFullPath(path);
        }


        public virtual char[] GetInvalidFileNameChars()
        {
            return Path.GetInvalidFileNameChars();
        }
        public virtual char[] GetInvalidPathChars()
        {
            return Path.GetInvalidPathChars();
        }


        public virtual string GetPathRoot(string path)
        {
            return Path.GetPathRoot(path);
        }


        public virtual string GetRandomFileName()
        {
            return Path.GetRandomFileName();
        }

        public virtual string GetTempFileName()
        {
            return Path.GetTempFileName();
        }

        public virtual string GetTempPath()
        {
            return Path.GetTempPath();
        }

        public virtual bool HasExtension(string path)
        {
            return Path.HasExtension(path);
        }




        public virtual bool IsPathRooted(string path)
        {
            return Path.IsPathRooted(path);
        }




#if NETSTANDARD2_1 || NETCORE21 || NETCORE22
        public virtual ReadOnlySpan<char> GetDirectoryName(ReadOnlySpan<char> path)
        {
            return Path.GetDirectoryName(path);
        }
        public virtual ReadOnlySpan<char> GetExtension(ReadOnlySpan<char> path)
        {
            return Path.GetExtension(path);
        }
        public virtual ReadOnlySpan<char> GetFileName(ReadOnlySpan<char> path)
        {
            return Path.GetFileName(path);
        }
        public virtual ReadOnlySpan<char> GetFileNameWithoutExtension(ReadOnlySpan<char> path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }
        public virtual ReadOnlySpan<char> GetFullPath(string path, string basePath)
        {
            return Path.GetFullPath(path, basePath);
        }
        public virtual ReadOnlySpan<char> GetPathRoot(ReadOnlySpan<char> path)
        {
            return Path.GetPathRoot(path);
        }
        public virtual string GetRelativePath(string relativeTo, string path)
        {
            return Path.GetRelativePath(relativeTo, path);
        }
        public virtual bool HasExtension(ReadOnlySpan<char> path)
        {
            return Path.HasExtension(path);
        }
        public virtual bool IsPathFullyQualified(string path)
        {
            return Path.IsPathFullyQualified(path);
        }

        public virtual string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2)
        {
            return Path.Join(path1, path2);
        }
        public virtual string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3)
        {
            return Path.Join(path1, path2, path3);
        }

        public virtual bool IsPathFullyQualified(ReadOnlySpan<char> path)
        {
            return Path.IsPathFullyQualified(path);
        }
        public virtual bool IsPathRooted(ReadOnlySpan<char> path)
        {
            return Path.IsPathRooted(path);
        }

        public virtual bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, Span<char> destination, out int charsWritten)
        {
            return Path.TryJoin(path1, path2, destination, out charsWritten);
        }
        public virtual bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3, Span<char> destination, out int charsWritten)
        {
            return Path.TryJoin(path1, path2, path3, destination, out charsWritten);
        }

        public string Join(string path1, string path2)
        {
            return Path.Join(path1, path2);
        }

        public string Join(string path1, string path2, string path3)
        {
            return Path.Join(path1, path2, path3);
        }

#endif

#if NETCORE30 
        public virtual bool EndsInDirectorySeparator(ReadOnlySpan<Char> path)
        {
            return Path.EndsInDirectorySeparator(path);
        }
        public virtual bool EndsInDirectorySeparator(String path)
        {
            return Path.EndsInDirectorySeparator(path);
        }

        public string Join(string[] paths)
        {
            return Path.Join(paths);
        }



        public string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3, ReadOnlySpan<char> path4)
        {
            return Path.Join(path1, path2, path3, path4);
        }

        public string Join(string path1, string path2, string path3, string path4)
        {
            return Path.Join(path1, path2, path3, path4);
        }

        public string TrimEndingDirectorySeparator(string path)
        {
            return Path.TrimEndingDirectorySeparator(path);
        }

        public ReadOnlySpan<char> TrimEndingDirectorySeparator(ReadOnlySpan<char> path)
        {
            return Path.TrimEndingDirectorySeparator(path);
        }
#endif
    }
}
