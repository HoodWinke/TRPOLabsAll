using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
   public abstract class LogAbstract
    {
        protected List<string> log = new List<string>();
        public abstract void _write();
        public abstract void _log(string str);
    }
}
