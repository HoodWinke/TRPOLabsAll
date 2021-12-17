using core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soldatkin
{
   public class MyLog : LogAbstract, ILog
    {
        public static MyLog Instance { get; } = new MyLog();
        private MyLog() { }

        public override void _write()
        {
            foreach (var logLine in log)
            {
                Console.WriteLine(logLine);
            }
        }

        internal bool ReadLine()
        {
            throw new NotImplementedException();
        }

        public override void _log(string str)
        {
            log.Add(str);
        }

        public void Log(string str) => Log(str);

        public void Write() => _write();
    }
}
