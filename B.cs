using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrpoLaba1
{
    class B : A
    {
        private object ProprtyA { get; set; }

        public A( object a)
        {
            PropertyA = a;
        }
    }
}
