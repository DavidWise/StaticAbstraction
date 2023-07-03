using System;
using System.Net.Security;
using System.Reflection;

namespace SATypeAnalyzer.Core
{
    public class AnalyzerParameter
    {
        public string Name => _parameter.Name;

#if NETCOREAPP3_0_OR_GREATER
        public Type? ParameterType => _parameter.ParameterType;
#endif
#if !NETCOREAPP3_0_OR_GREATER
        public Type ParameterType => _parameter.ParameterType;
#endif

        protected ParameterInfo _parameter;

        public bool IsOptional { get; protected set; }
        public bool HasDefaultValue { get; protected set; }
        public Type DefaultValueType { get; protected set; }
        public string DefaultValueFullName { get; protected set; }

        public AnalyzerParameter(ParameterInfo paramInfo)
        {
            _parameter = paramInfo;
            AnalyzeParam(paramInfo);
        }
        public override string ToString()
        {
            var optional = this.IsOptional ? "Optional " : "";
            var result = $"{optional}{this.ParameterType.Stringify()} {this.Name}";

            if (this.HasDefaultValue)
            {
                result += $" = {this.DefaultValueFullName}";
            }
            return result;
        }

        private void AnalyzeParam(ParameterInfo param)
        {
            if (param.DefaultValue == null) return;

            try
            {
                this.IsOptional = (param.Attributes & ParameterAttributes.Optional) == ParameterAttributes.Optional;
                this.HasDefaultValue = (param.Attributes & ParameterAttributes.HasDefault) == ParameterAttributes.HasDefault;

                if (!this.HasDefaultValue) return;

                this.DefaultValueType = param.DefaultValue.GetType();

                if (this.DefaultValueType.IsEnum)
                {
                    this.DefaultValueFullName = $"{this.DefaultValueType.FullName}.{param.DefaultValue.ToString()}";
                } else
                {
                    this.DefaultValueFullName = $"{param.DefaultValue.ToString()}";
                }

            } catch(Exception ex)
            {
                var t = 123;
            }

        }
    }
}
