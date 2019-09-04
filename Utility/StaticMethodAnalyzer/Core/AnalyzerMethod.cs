using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace StaticMethodAnalayzer.Core
{
    class AnalyzerMethod
    {
        public string Name { get; protected set; }
        public bool IsStatic => _method.IsStatic;
        public Type ReturnType { get; protected set; }
        public int OriginalPosition { get; set; }
        public int ParameterCount { get; protected set; }
        public IList<AnalyzerParameter> Parameters { get; protected set; }

        public bool IsUnderlyingSetterGetter { get; protected set; }

        protected MethodInfo _method;

        public AnalyzerMethod(MethodInfo method)
        {
            _method = method;
            this.Name = method.Name;
            this.ReturnType = method.ReturnType;
            this.Parameters = new List<AnalyzerParameter>();

            if (this.Name.StartsWith("get_") || this.Name.StartsWith("set_"))
            {
                this.IsUnderlyingSetterGetter = (method.Attributes & MethodAttributes.SpecialName) == MethodAttributes.SpecialName;
            }

            var methodParams = method.GetParameters();

            if (methodParams != null && methodParams.Length > 0)
            {
                ParameterCount = methodParams.Length;

                foreach (var methodParam in methodParams)
                {
                    var newParam = new AnalyzerParameter(methodParam);
                    this.Parameters.Add(newParam);
                }
            }
        }

        public override string ToString()
        {
            var modifiers = new List<string>();

            var scope = _method.IsPublic ? "public" : "private";
            modifiers.Add(scope);

            if (_method.IsStatic) modifiers.Add("static");
            if (_method.IsVirtual) modifiers.Add("virtual");

            var modifierText = string.Join(" ", modifiers.ToArray());

            var formattedParams = this.Parameters.Select(x => x.ToString()).ToArray();
            var result = $"{modifierText} {this.ReturnType.Stringify()} {this.Name}(" +
                string.Join(", ", formattedParams) + ")";

            return result;
        }
    }
}
