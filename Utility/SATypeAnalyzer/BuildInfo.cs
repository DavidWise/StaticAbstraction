using System.IO;

namespace SATypeAnalyzer
{




    public class BuildInfo
    {
        public SupportedFramework TargetFramework { get; protected set; }
        public string OutputPath { get; protected set; }


        public BuildInfo(string outputPath)
        {
            SetTargetFramework();

            BuildPaths(outputPath);
        }

        protected void BuildPaths(string basePath)
        {
            var tempPath = Path.Combine(basePath, this.TargetFramework.ToString());
            if (!Directory.Exists(tempPath)) Directory.CreateDirectory(tempPath);
            this.OutputPath = tempPath;
        }

        protected void SetTargetFramework()
        {
            this.TargetFramework = BuildConstants.Framework;
        }
    }
}
