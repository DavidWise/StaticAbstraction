using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace SATypeAnalyzer.Core
{
    class AnalyzerProperty
    {
        public bool IsGetter { get; protected set; }
        public bool IsSetter { get; protected set; }
        public Type ReturnType { get; protected set; }
        public int OriginalPosition { get; set; }
        public string Name {get; protected set;}

        protected PropertyInfo _property;

        public AnalyzerProperty(PropertyInfo info)
        {
            Analyze(info);
        }

        public void Extend(PropertyInfo info)
        {
            Analyze(info);
        }

        protected void Analyze(PropertyInfo info)
        {
            if (_property == null) _property = info;
            if (this.ReturnType == null) this.ReturnType = info.PropertyType;

            if (info.CanRead)
                this.IsGetter = true;
            if (info.CanWrite)
                this.IsSetter = true;

            if (this.Name == null)
            {
                this.Name = GetName(info);
            }
        }

        public bool MatchesName(PropertyInfo info)
        {
            var matchName = GetName(info);
            return string.Compare(this.Name, matchName, StringComparison.InvariantCultureIgnoreCase) == 0;
        }

        public override string ToString()
        {
            var getset = "";
            if (IsGetter) getset += "get; ";
            if (IsSetter) getset += "set; ";

            return $"{ReturnType.Stringify()} {Name} {{ {getset} }}";
        }

        protected string GetName(PropertyInfo info)
        {
            var matchName = info.Name;
            if (info.CanRead && matchName.StartsWith("get_")) matchName = matchName.Substring(4);
            if (info.CanWrite && matchName.StartsWith("set_")) matchName = matchName.Substring(4);
            return matchName;
        }
    }
}
