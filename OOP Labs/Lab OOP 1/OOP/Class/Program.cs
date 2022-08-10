using System;
using System.Linq;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Doctor 

            Doctor doc = new Doctor();
            Console.WriteLine("enter doctor id");
            doc.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter doctor name");
            doc.Name = Console.ReadLine();
            Console.WriteLine("enter doctor age");
            doc.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter doctor specification");
            doc.Specification = (Console.ReadLine());
            Console.WriteLine("enter doctor grade");
            doc.Grade = (int.Parse(Console.ReadLine()));
            Console.WriteLine(doc.Id);
            Console.WriteLine(doc.Name);
            Console.WriteLine(doc.Age);
            Console.WriteLine(doc.Specification);
            Console.WriteLine(doc.Grade);
            Console.WriteLine(doc.print());
            Doctor doctor = new Doctor(){Age = 20,Grade = 50,Id = 1,Name = "aya",Specification = "Children doc"};
            Console.WriteLine(doctor.print());

            #endregion

        }
    }
}
