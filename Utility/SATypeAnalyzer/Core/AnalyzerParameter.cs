﻿using System;
using System.Reflection;

namespace SATypeAnalyzer.Core
{
    public class AnalyzerParameter
    {
        public string Name => _parameter.Name;
        public Type ParameterType => _parameter.ParameterType;

        protected ParameterInfo _parameter;

        public AnalyzerParameter(ParameterInfo paramInfo)
        {
            _parameter = paramInfo;
        }
        public override string ToString()
        {
            return $"{this.ParameterType.Stringify()} {this.Name}";
        }
    }
}
