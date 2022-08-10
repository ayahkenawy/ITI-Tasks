using System;
using System.Linq;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Doctor 1

            //Doctor doc = new Doctor();
            //Console.WriteLine("enter doctor id");
            //doc.setId(int.Parse(Console.ReadLine()));
            //Console.WriteLine("enter doctor name");
            //doc.setName(Console.ReadLine());
            //Console.WriteLine("enter doctor age");
            //doc.setAge(int.Parse(Console.ReadLine()));
            //Console.WriteLine("enter doctor specification");
            //doc.setSpecification(Console.ReadLine());
            //Console.WriteLine("enter doctor grade");
            //doc.setgrade(int.Parse(Console.ReadLine()));
            //Console.WriteLine(doc.getId());
            //Console.WriteLine(doc.getName());
            //Console.WriteLine(doc.getAge());
            //Console.WriteLine(doc.getSpecification());
            //Console.WriteLine(doc.getgrade());
            //Console.WriteLine(doc.print());

            #endregion

            #region doc 3

            //Doctor[] docs = new Doctor[3];
            //docs[0] = new Doctor();
            //docs[1] = new Doctor();
            //docs[2] = new Doctor();
            //for (int i = 0; i < docs.Length; i++)
            //{
            //    Console.WriteLine($"Enter Data For Doctor index {i}");
            //    Console.WriteLine("Enter Doctor ID");
            //    docs[i].setId(int.Parse(Console.ReadLine()));
            //    Console.WriteLine("Enter Doctor Name");
            //    docs[i].setName(Console.ReadLine());
            //    Console.WriteLine("Enter Doctor Age");
            //    docs[i].setAge(int.Parse(Console.ReadLine()));
            //    Console.WriteLine("Enter Doctor Specification");
            //    docs[i].setSpecification(Console.ReadLine());
            //    Console.WriteLine("Enter Doctor Grade");
            //    docs[i].setgrade(int.Parse(Console.ReadLine()));
            //}
            //Console.Clear();
            //for (int i = 0; i < docs.Length; i++)
            //{
            //    Console.WriteLine($"Data for Doctor at index {i}");
            //    Console.WriteLine(docs[i].print());
            //}

            #endregion

            #region Bouns

            string choice;
            int[] indexArr = new int[0];
            Doctor[] docNum = new Doctor[10];
            do
            {
                Console.WriteLine("Choose Which Doctor Index You Want To Enter His Data Form 0 to 10");
                int i = int.Parse(Console.ReadLine());
                indexArr = indexArr.Append(i).ToArray();
                docNum[i] = new Doctor();
                Console.WriteLine("Enter Doctor ID");
                docNum[i].setId(int.Parse(Console.ReadLine()));
                Console.WriteLine("Enter Doctor Name");
                docNum[i].setName(Console.ReadLine());
                Console.WriteLine("Enter Doctor Age");
                docNum[i].setAge(int.Parse(Console.ReadLine()));
                Console.WriteLine("Enter Doctor Specification");
                docNum[i].setSpecification(Console.ReadLine());
                Console.WriteLine("Enter Doctor Grade");
                docNum[i].setgrade(int.Parse(Console.ReadLine()));
                Console.WriteLine("Do You Want To continue ? yes / no ");
                choice = Console.ReadLine();
            } while (choice == "yes");

            for (int i = 0; i < indexArr.Length; i++)
            {

                Console.WriteLine($"Data for Doctor at index {indexArr[i]}");
                Console.WriteLine(docNum[indexArr[i]].print());
            }
            #endregion
        }
    }
}
