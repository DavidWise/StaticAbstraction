using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using StaticAbstraction.Diagnostics.Interface;

namespace StaticAbstraction.Diagnostics
{


    public class StAbProcessModuleCollection : IProcessModuleCollection
    {
        private List<IProcessModule> _modules;
        public virtual int Count => _modules.Count;


        public StAbProcessModuleCollection()
        {
            _modules = new List<IProcessModule>();
        }

        public StAbProcessModuleCollection(IEnumerable<IProcessModule> modules)
        {
            if (modules != null)
            {
                foreach (var module in modules)
                    this.Add(module);
            }
        }

        public StAbProcessModuleCollection(ProcessModule[] modules)
        {
            if (modules != null && modules.Length>0)
            {
                foreach (var module in modules)
                    this.Add(module);
            }
        }


        protected void Add(IProcessModule module)
        {
            if (module != null) _modules.Add(module);
        }


        protected void Add(ProcessModule module)
        {
            if (module == null) return;
            var newMod = new StAbProcessModule(module);
            _modules.Add(newMod);
        }


        public virtual IEnumerator<IProcessModule> GetEnumerator()
        {
            return _modules.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _modules.GetEnumerator();
        }
    }
}
