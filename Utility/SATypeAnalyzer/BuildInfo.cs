﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SATypeAnalyzer
{
    public enum SupportedFramework
    {
        Unknown,
        Framework40,
        Framework45,
        Framework46,
        Framework47,
        Framework48,
        Core22,
        Core30,
        Core,
        NetStandard,
        NetStandard2,
        NetStandard21
    }
    public class BuildInfo
    {
        public SupportedFramework TargetFramework { get; protected set; }
        public string OutputPath{ get; protected set; }

        public BuildInfo(string outputPath)
        {
            SetTargetFramework();
            if (TargetFramework == SupportedFramework.Unknown) throw new ApplicationException("Unknown target framework");
            var tempPath = Path.Combine(outputPath, this.TargetFramework.ToString());
            if (!Directory.Exists(tempPath)) Directory.CreateDirectory(tempPath);
            this.OutputPath = tempPath;
        }

        protected void SetTargetFramework()
        {
#if NET40
            this.TargetFramework = SupportedFramework.Framework40;
#endif
#if NET45
            this.TargetFramework = SupportedFramework.Framework45;
#endif
#if NET46
            this.TargetFramework = SupportedFramework.Framework46;
#endif
#if NET47
            this.TargetFramework = SupportedFramework.Framework47;
#endif

#if NETCORE
            this.TargetFramework = SupportedFramework.Core;
#endif
#if NETSTANDARD2_0
            this.TargetFramework = SupportedFramework.NetStandard2;
#endif
#if NET48
            this.TargetFramework = SupportedFramework.Framework48;
#endif
#if NETCORE22
            this.TargetFramework = SupportedFramework.Core22;
#endif

#if NETSTANDARD2_1
            this.TargetFramework = SupportedFramework.NetStandard21;
#endif
#if NETCORE30
            this.TargetFramework = SupportedFramework.Core30;
#endif

        }
    }
}