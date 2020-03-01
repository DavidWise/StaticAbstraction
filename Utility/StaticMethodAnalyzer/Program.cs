using SATypeAnalyzer;
using System;
using System.IO;
using System.Reflection;

namespace StaticMethodAnalayzer
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = GetOutputPath();

            var analyzer = new TypeAnalyzer(path);

            analyzer.Go();
        }

        private static string GetOutputPath()
        {
            var result = "";  //@"D:\Dev\Github\StaticAbstraction\Utility\StaticMethodAnalyzer\Output";
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            var libInfo = new FileInfo(path);
            var curDir = libInfo.Directory;

            while (curDir.Parent != null && result == "")
            {
                var targetDir = string.Format("{0}\\Output", curDir.FullName.TrimEnd('\\'));
                if (Directory.Exists(targetDir))
                {
                    result = targetDir;
                } else
                {
                    curDir = curDir.Parent;
                }
            }

            return result;
        }
    }
}
