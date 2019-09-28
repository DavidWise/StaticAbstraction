using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SATypeAnalyzer.Core
{
    public static class ExtensionMethods
    {
        private static string[] _commonNamespaces =
        {
            "System",
            "System.Collections",
            "System.Collections.Generic",
            "System.IO"
        };

        public static string Stringify(this Type type)
        {
            var result = string.Empty;
            if (type != null)
            {
                if (type.IsGenericType) return StringifyGeneric(type);
                
                if (_commonNamespaces.Any(x=> x == type.Namespace) )
                {
                    result = type.Name;
                } else
                {
                    result = type.FullName;
                }
            }
            return result;
        }

        private static string StringifyGeneric(Type type)
        {
            var result = string.Empty;

            var name = type.Name;
            var pos = name.IndexOf('`');
            if (pos > 0) name = name.Substring(0, pos);

            var fullName = type.Namespace + "." + name;
            var useName = fullName;
            if (_commonNamespaces.Any(x => x == type.Namespace))
                useName = name;

                var genTypes = new List<string>();
            var genArgs = type.GetGenericArguments();
            foreach (var inType in genArgs)
            {
                genTypes.Add(inType.Stringify());
            }

            var genParams = string.Join(",", genTypes.ToArray());

            return $"{useName}<{genParams}>";
        }
    }
}
