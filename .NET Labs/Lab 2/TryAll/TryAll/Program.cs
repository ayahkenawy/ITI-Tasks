using System;
using System.Globalization;

namespace TryAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
        ////    2.Design and implement a structure for the employees in a company
        ////    3.Employee is identified by an ID, security level, salary, hire date and Gender.
        ////    4.Develop a Structure to represent the HiringDate Data Type consisting of fields to hold the day, month and Years.
        ////    5.We need to restrict the Gender field to be only M or F[Male of Female](Use Enum.Parse)
        ////    6.Assign the security privileges to the employee in a form of byte Flag enum, security privileges are guest, Developer, secretary and DBA.
        ////    7.We want to provide the Employee structure with the standard capabilities to represent Employee data in a string Form (override ToString()),
        ////    display employee salary in a currency format. [use String.Format Function,
        ////    do you need additional using Directive ]
        ////    8.Create an array of Employees with size three a DBA, Guest 
        ////    9.Implement All the Necessary Member Functions on the Structure(Getters, Setters)
        ////    10.Define all the Necessary Constructors for the Structure
        ////    11.Read ALL Data from End User
        ////    12.Allow NO RUNTIME errors if the user inputs any data

            #region 
            //هسأل عن GetHashCode ليه بتطلع نفس القيمة و اعرفها ازاي في Struct 
            //Employee employee = new Employee();
            //employee.Id = employee.GetHashCode();
            //Console.WriteLine(employee.Id);
            //Employee emp = new Employee();
            //emp.Id = emp.GetHashCode();
            //Console.WriteLine(emp.Id);
            // Enum.Parse();
            //How to Convert Enum To LowerCase
            #endregion

            Employee[] employee = new Employee[3];
            string str;
            Gender gen;
            Position pos = Position.officer;
            pos ^= Position.guest;
            Console.WriteLine(pos);
            decimal d;
            DateTime date;
            try
            {
                for (int i = 0; i < employee?.Length; i++)
            {
                do
                {
                    Console.WriteLine($"Please Enter Employee {i} Gender Male or Female");
                    str = Console.ReadLine().ToLower();
                } while (!Array.Exists(Enum.GetNames(typeof(Gender)), element => element == str));

                gen = (Gender)Enum.Parse(typeof(Gender), str);
                employee[i].Gender = gen;

                do
                {
                    Console.WriteLine($"Please Enter Employee {i} Position Guest Or Developer Or Secretary Or DBA Or Officer");
                    str = Console.ReadLine().ToLower();
                } while (!Enum.IsDefined(typeof(Position), str));

                pos = (Position)Enum.Parse(typeof(Position), str);
                employee[i].Position = pos;

                do
                {
                    Console.WriteLine($"Please Enter Employee {i} HireDate dd/mm/yyyy");
                } while (!DateTime.TryParseExact(Console.ReadLine(), "dd/mm/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out date));

                HireDate hrdt = new HireDate(date.Day,date.Month,date.Year);
                employee[i].HireDate=hrdt;

                do
                {
                    Console.WriteLine($"Please Enter Employee {i} Salary");
                } while (!decimal.TryParse(Console.ReadLine(), out d));
                employee[i].Salary = d;
                employee[i].Id = employee[i].GetHash();
                Console.WriteLine(employee[i]);
            }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
