using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryDependancyInjection
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        ILog Log;
        public Student(ILog _log)
        {
            Log = _log;
        }
        public void StudError(string msg)
        {
            Log.Log(msg);
        }
    }
}
