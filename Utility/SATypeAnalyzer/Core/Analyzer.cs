using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using System.IO;

namespace SATypeAnalyzer.Core
{
    class Analyzer
    { 
        public IList<AnalyzerMethod> Methods { get; protected set; }
        public IList<AnalyzerProperty> Properties { get; protected set; }
        public string Name => _type.Name;
        public string FullName => _type.FullName;

        protected Type _type;
        public Analyzer(Type type)
        {
            _type = type;
            this.Methods = new List<AnalyzerMethod>();
            this.Properties = new List<AnalyzerProperty>();
            GetMethods();
            GetProperties();

        }

        protected void GetMethods() { 
            var methods = _type.GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance );

            int pos = 0;
            foreach(var method in methods)
            {
                var info = new AnalyzerMethod(method) { OriginalPosition = pos++ };

                if (!info.IsUnderlyingSetterGetter)
                    Methods.Add(info);
            }
        }

        protected void GetProperties()
        {
            var properties = _type.GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance | BindingFlags.SetProperty | BindingFlags.GetProperty);

            int pos = 0;
            foreach (var prop in properties)
            {
                var info = new AnalyzerProperty(prop) { OriginalPosition = pos++ };

                var existing = this.Properties.SingleOrDefault(x => x.MatchesName(prop));

                if (existing == null)
                    Properties.Add(info);
                else
                    existing.Extend(prop);
            }

        }



        public void WriteToFile(string directoryPath) 
        {
            if (!Directory.Exists(directoryPath)) throw new DirectoryNotFoundException($"The specified folder '{directoryPath}' does not exist");

            var path = Path.Combine(directoryPath, this.FullName);

            var body = new StringBuilder();

            var orderedMethods = this.Methods.OrderBy(x=>x.IsStatic == false).ThenBy(x => x.Name).ThenBy(x => x.ParameterCount).ThenBy(x=>x.OriginalPosition);
            foreach(var item in orderedMethods)
            {
                body.AppendLine(item.ToString());
            }

            var orderedProperties = this.Properties.OrderBy(x => x.Name).ThenBy(x => x.IsGetter == false || x.IsSetter == false).ThenBy(x => x.OriginalPosition);
            foreach (var item in orderedProperties)
            {
                body.AppendLine(item.ToString());
            }

            var fullBody = body.ToString();

            if (File.Exists(path)) File.Delete(path);
            File.WriteAllText(path, fullBody);
        }
    }
}
