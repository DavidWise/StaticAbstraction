using System.Diagnostics;
using StaticAbstraction.Diagnostics.Interface;

namespace StaticAbstraction.Diagnostics
{

#if NET40_OR_GREATER || NETCOREAPP3_0_OR_GREATER
    public class StAbFileVersionInfoInstance : IFileVersionInfoInstance
    {
        protected FileVersionInfo WrappedObject { get; private set; }

        public virtual bool IsPreRelease => WrappedObject.IsPreRelease;
        public virtual int ProductPrivatePart => WrappedObject.ProductPrivatePart;
        public virtual int ProductMinorPart  => WrappedObject.ProductMinorPart;
        public virtual int ProductMajorPart  => WrappedObject.ProductMajorPart;
        public virtual int ProductBuildPart  => WrappedObject.ProductBuildPart;
        public virtual string PrivateBuild  => WrappedObject.PrivateBuild;
        public virtual string ProductName  => WrappedObject.ProductName;
        public virtual string OriginalFilename  => WrappedObject.OriginalFilename;
        public virtual string LegalTrademarks  => WrappedObject.LegalTrademarks;
        public virtual string LegalCopyright  => WrappedObject.LegalCopyright;
        public virtual string Language  => WrappedObject.Language;
        public virtual bool IsSpecialBuild  => WrappedObject.IsSpecialBuild;
        public virtual bool IsPrivateBuild  => WrappedObject.IsPrivateBuild;
        public virtual string ProductVersion  => WrappedObject.ProductVersion;
        public virtual string SpecialBuild  => WrappedObject.SpecialBuild;
        public virtual bool IsDebug  => WrappedObject.IsDebug;
        public virtual string InternalName  => WrappedObject.InternalName;
        public virtual string FileVersion  => WrappedObject.FileVersion;
        public virtual int FilePrivatePart  => WrappedObject.FilePrivatePart;
        public virtual string FileName  => WrappedObject.FileName;
        public virtual int FileMinorPart  => WrappedObject.FileMinorPart;
        public virtual int FileMajorPart  => WrappedObject.FileMajorPart;
        public virtual string FileDescription  => WrappedObject.FileDescription;
        public virtual int FileBuildPart  => WrappedObject.FileBuildPart;
        public virtual string CompanyName  => WrappedObject.CompanyName;
        public virtual string Comments  => WrappedObject.Comments;
        public virtual bool IsPatched  => WrappedObject.IsPatched;

        public StAbFileVersionInfoInstance(FileVersionInfo info)
        {
            if (info == null) return;
            WrappedObject = info;
        }

        public override string ToString()
        {
            if (WrappedObject == null) return null;

            return WrappedObject.ToString();
        }
    }

#endif
}
