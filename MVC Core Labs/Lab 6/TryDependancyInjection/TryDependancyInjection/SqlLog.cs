using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryDependancyInjection
{
    public class SqlLog:ILog
    {
        public void Log(string msg)
        {
            Console.WriteLine($"{msg} Is Logged Inside Sql");
        }
    }
}
