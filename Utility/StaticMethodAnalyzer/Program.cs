using StaticMethodAnalayzer.Core;
using System;
using System.Collections.Generic;

namespace StaticMethodAnalayzer
{
    class Program
    {
        private static Type[] _typesToAnalyze =
        {
            typeof(System.IO.Directory),
            typeof(System.IO.DirectoryInfo),
            typeof(System.IO.File),
            typeof(System.IO.FileInfo),
            typeof(System.Console),
            typeof(System.DateTime),
            typeof(System.IO.DriveInfo),
            typeof(System.IO.Path),
            typeof(System.IO.FileSystemInfo),
            typeof(System.Reflection.Assembly)
        };

        static void Main(string[] args)
        {
            var path = @"D:\Dev\Github\StaticAbstraction\Utility\StaticMethodAnalayzer\Output";

            var info = new BuildInfo(path);

            foreach (var checkType in _typesToAnalyze)
            {
                var zer = new Analyzer(checkType);
                zer.WriteToFile(info.OutputPath);
            }
        }
    }
}
