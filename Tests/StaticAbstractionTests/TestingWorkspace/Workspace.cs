using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StaticAbstractionTests.TestingWorkspace
{
    public class Workspace : IDisposable
    {
        protected static string _sourceFolder;
        protected static string _scratchFolder;

        private static char[] _invalidFileNameChars;
        private static char[] _invalidPathNameChars;
        private static char[] _invalidChars;

        public string SourceFolder => _sourceFolder;
        public string ScratchFolder => _scratchFolder;

        protected List<string> foldersCreated = new List<string>();

        static Workspace()
        {
            _invalidFileNameChars = Path.GetInvalidFileNameChars();
            _invalidPathNameChars = Path.GetInvalidPathChars();

            _invalidChars = _invalidFileNameChars.Concat(_invalidPathNameChars).Distinct().ToArray();
            // TODO: get real path via reflection at another time

            _sourceFolder = @"D:\Dev\Github\StaticAbstraction\Tests\StaticAbstractionTests\TestingWorkspace";

            _scratchFolder = BuildScratchFolder(_sourceFolder, "Scratch");
        }


        protected static string BuildScratchFolder(string basePath, string scratchFolderName)
        {
            if (!Directory.Exists(basePath)) throw new DirectoryNotFoundException($"Unable to access workspace directory '{basePath}' ");

            var containerFullPath = Path.Combine(basePath, scratchFolderName);
            CleanScratchDir(basePath, containerFullPath);
            return containerFullPath;
        }

        protected static void CleanScratchDir(string basePath, string path, bool createIfNeeded = true)
        {
            if (!path.StartsWith(basePath, StringComparison.InvariantCultureIgnoreCase))
                throw new ArgumentException($"The target scratch dir '{path}' MUST be underneath the workspace '{basePath}'!");

            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }

            if (createIfNeeded)
            {
                Directory.CreateDirectory(path);
            }
        }

        public string CreateDirectoryForTest(string testName)
        {
            if (string.IsNullOrWhiteSpace(testName)) throw new ArgumentException("The a valid test name is required");

            if (testName.IndexOfAny(_invalidChars) >= 0) throw new ArgumentException($"The test name '{testName}' cannot contain the characters '{string.Join("", _invalidChars)}'");

            var dirPath = Path.Combine(ScratchFolder, testName);
            CleanScratchDir(ScratchFolder, dirPath);

            foldersCreated.Add(dirPath);

            return dirPath;
        }

        public void Dispose()
        {
            if (foldersCreated.Count() == 0) return;

            foreach(var folder in foldersCreated)
            {
                CleanScratchDir(_scratchFolder, folder, false);
            }

            foldersCreated.Clear();
        }
    }
}
