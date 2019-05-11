using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace StaticAbstraction.Reflection
{

    public class StAbAssembly : IAssembly
    {
        // TODO: finish fleshing this out
        protected Assembly _assembly;

        public StAbAssembly() { }

        public StAbAssembly(Assembly assembly)
        {
            _assembly = assembly;
        }

        public string CodeBase => _assembly?.CodeBase;

        public string Location
        {
            get { return _assembly?.Location; }
        }

        public string[] GetManifestResourceNames()
        {
            return _assembly?.GetManifestResourceNames();
        }

        public Stream GetManifestResourceStream(string name)
        {
            return _assembly?.GetManifestResourceStream(name);
        }
    }
}
