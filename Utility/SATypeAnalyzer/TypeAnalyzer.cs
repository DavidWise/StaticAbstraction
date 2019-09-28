using SATypeAnalyzer.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace SATypeAnalyzer
{
    public class TypeAnalyzer
    {
        private Type[] _typesToAnalyze =
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

        BuildInfo _info;

        public TypeAnalyzer(string outputPath)
        {
            _info = new BuildInfo(outputPath);
        }

        public void Go()
        {
            foreach (var checkType in _typesToAnalyze)
            {
                var zer = new Analyzer(checkType);
                zer.WriteToFile(_info.OutputPath);
            }
        }
    }
}
