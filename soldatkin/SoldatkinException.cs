using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace soldatkin
{
    [Serializable]
    public class SoldatkinException : Exception
    {
            public SoldatkinException()
            {
            }

            public SoldatkinException(string message) : base(message)
            {
            }

            public SoldatkinException(string message, Exception inner) : base(message, inner)
            {
            }

            protected SoldatkinException(SerializationInfo info, StreamingContext context) : base(info, context)
            {
            }
    }
}
