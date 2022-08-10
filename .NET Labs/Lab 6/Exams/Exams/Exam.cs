using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams
{
    abstract class Exam
    {
        public  DateTime Date { get; set; }
        public int Duration { get; set; }

        public Dictionary<Question,Answer> Questions =new Dictionary<Question,Answer>();

        public  virtual string ShowExam()
        {
            return "";
        }

       
    }
}
