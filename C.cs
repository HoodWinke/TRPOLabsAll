using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrpoLaba1
{
    class C : B
    {
        private object ProprtyB { get; set; }

        public C( object b)
        {
            PropertyB = b;
        }
    }
}
