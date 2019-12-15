using System;

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
        Core20,
        Core21,
        Core22,
        Core30,
        Core,
        NetStandard,
        NetStandard2,
        NetStandard21
    }

    public static class BuildConstants
    {

#if NET40
        public const string FrameworkName = "NET40";
        public const SupportedFramework Framework = SupportedFramework.Framework40;
#endif
#if NET45
        public const string FrameworkName = "NET45";
        public const SupportedFramework Framework = SupportedFramework.Framework45;
#endif
#if NET46
        public const string FrameworkName = "NET46";
        public const SupportedFramework Framework = SupportedFramework.Framework46;
#endif
#if NET47
        public const string FrameworkName = "NET47";
        public const SupportedFramework Framework = SupportedFramework.Framework47;
#endif

#if NET48
        public const string FrameworkName = "NET48";
        public const SupportedFramework Framework = SupportedFramework.Framework48;
#endif
#if NETCORE20
        public const string FrameworkName = "CORE20";
        public const SupportedFramework Framework = SupportedFramework.Core20;
#endif
#if NETCORE21
        public const string FrameworkName = "CORE21";
        public const SupportedFramework Framework = SupportedFramework.Core21;
#endif
#if NETCORE22
        public const string FrameworkName = "CORE22";
        public const SupportedFramework Framework = SupportedFramework.Core22;

#endif

#if NETCORE30
        public const string FrameworkName = "CORE30";
        public const SupportedFramework Framework = SupportedFramework.Core30;

#endif

#if NETSTANDARD2_0
        public const string FrameworkName = "NETSTANDARD2_0";
        public const SupportedFramework Framework = SupportedFramework.NetStandard2;
#endif
#if NETSTANDARD2_1
        public const string FrameworkName = "NETSTANDARD2_1";
        public const SupportedFramework Framework = SupportedFramework.NetStandard21;
#endif


    }
}
