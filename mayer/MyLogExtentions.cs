using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soldatkin
{
    public static class MyLogExtentions
    {
        public static string ReadLine(this MyLog myLog)
        {
            var line = Console.ReadLine();
            myLog.Log(line);
            return line;
        }
    }
}
