using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Action_predicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emps = new List<Employee>(){
            new Employee { ID = 1, Name = "Aya", Age = 22, Salary = 10234, DeptId = 1 },
            new Employee { ID = 2, Name = "Ali", Age = 23, Salary = 9234, DeptId = 1 },
            new Employee { ID = 3, Name = "Ziad", Age = 24, Salary = 8234, DeptId = 2 },
            new Employee { ID = 4, Name = "Sara", Age = 32, Salary = 7234, DeptId = 2 },
            new Employee { ID = 5, Name = "Ahmed", Age = 42, Salary = 6234, DeptId = 3 },
            new Employee { ID = 6, Name = "Osama", Age = 22, Salary = 5234, DeptId = 2 },
            new Employee { ID = 7, Name = "Martin", Age = 22, Salary = 4234, DeptId = 2 },
            new Employee { ID = 8, Name = "Waleed", Age = 27, Salary = 3234, DeptId = 3 },
            new Employee { ID = 9, Name = "Heba", Age = 28, Salary = 2345, DeptId = 1 },
            new Employee { ID = 10, Name = "Mohamed", Age = 29, Salary = 1234, DeptId = 1 }};
            Predicate<Employee> emp = empfilter => empfilter.Age == 22;
            Console.WriteLine(emp.Invoke(new Employee { ID = 1, Name = "Aya", Age = 22, Salary = 10234, DeptId = 1 }));

            //Action<List<Employee>> emp1 = employees => employees.Sort();
            //emp1(emps);
            Func<List<Employee>, List<Employee>> emp1 = employees => employees;
           Console.WriteLine(emp1(emps).Count());
           List<Employee> filterEmps = emps.FindAll(item => item.Age > 27);
           foreach (var item in filterEmps)
           {
               Console.WriteLine(item);
           }
           
           Console.ReadKey();
        }
    }
}
