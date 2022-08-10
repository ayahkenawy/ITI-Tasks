
using Unity;

namespace TryDependancyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //v1
            //Employee employee = new Employee { Id=1,Name="Aya"};
            //employee.EmpError("Emp Not Exist");
            //v2
            //FileLog Flog = new FileLog();
            //Employee E1 = new Employee(Flog);
            //E1.EmpError("Emp Not Exist");
            //v3
            //SqlLog sLog = new SqlLog();
            //FileLog Flog = new FileLog();
            //Student S1 = new Student(Flog);
            //S1.StudError("Stud Has No Key");
            //v4
            var container = new UnityContainer();
            container.RegisterType<ILog, FileLog>();
            //container.RegisterType<ILog, SqlLog>();
            //container.RegisterType<ILog, ConsoleLog>();
            Student st = container.Resolve<Student>();
            st.StudError("Show Msg");
        }
    }
}