using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MCQ Q = new MCQ();
            Answer Ans = new Answer();
            Answer Ans1 = new Answer();
            Answer Ans2 = new Answer();
            PracticeExam Ex = new PracticeExam();
            FinalExam FiEx = new FinalExam();
            Console.WriteLine("Enter First Q Body");
            Q.Body = Console.ReadLine();
            Console.WriteLine("Enter First Q Mark");
            Q.Mark = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter First Q Answer 1");
            Ans.Answers = Console.ReadLine();
            Console.WriteLine("Enter First Q Answer 2");
            Ans1.Answers = Console.ReadLine();
            Console.WriteLine("Enter First Q Answer 3");
            Ans2.Answers = Console.ReadLine();
            List<Answer> answers = new List<Answer>();
            answers.Add(Ans);
            answers.Add(Ans1);
            answers.Add(Ans2);
            Q.Choices.AddRange(answers);
            Console.WriteLine("Enter Exam Date");
            Ex.Date = DateTime.Parse(Console.ReadLine());
            FiEx.Date = Ex.Date;
            Console.WriteLine("Enter Exam Duration");

            Ex.Duration = int.Parse(Console.ReadLine());
            FiEx.Duration = Ex.Duration;
            Ex.Questions.Add(Q, Ans);
            FiEx.Questions.Add(Q, Ans);
            Console.WriteLine(Ex.ShowExam());
            Console.WriteLine(FiEx.ShowExam());
            Console.ReadLine();
            Q.Add();


        }
    }
}
