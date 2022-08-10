using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams
{
     class Answer
    {
        public string Answers { get; set; }
        public override string ToString()
        {
            return $"{Answers}";
        }
    }
}
