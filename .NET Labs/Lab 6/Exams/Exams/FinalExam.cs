using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams
{
     class FinalExam:Exam
    {
        public override string ShowExam()
        {
            string str = "";
            foreach (var Q in Questions)
            {
                str += $"Question : {Q.Key} ";
            }

            return str;
        }
        
    }
}
