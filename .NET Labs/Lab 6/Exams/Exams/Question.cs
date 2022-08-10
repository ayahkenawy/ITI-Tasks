using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams
{
    abstract class Question
    {
        public  string Body { get; set; }
        public int Mark { get; set; }
        public List<Answer> Choices = new List<Answer>();

        public  void Add()
        {
            int count = 0;
            StreamWriter text = new StreamWriter("E:\\.NET ITI\\.net C#\\Day 6\\Lab 6\\Ques.txt", append: true);

            text.WriteLine($"Question : {this.Body} ");
            foreach (var choice in Choices)
            {
                count++;
                text.WriteLine($"Choice {count} : {choice}");

            }
            text.Close();
        }

        public override string ToString()
        {
            return $"{Body}";
        }
    }
}
