

namespace TryDependancyInjection
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        ConsoleLog Clog;
        FileLog Flog;
        SqlLog SLog;
        public Employee()
        {
            // Clog = new ConsoleLog();
            
        }
        public Employee(FileLog _flog)
        {
           // Clog = new ConsoleLog();
           Flog = _flog;
        }
        public void EmpError(string ErrorMsg)
        {
           // Clog.Log(ErrorMsg);
           Flog.Log(ErrorMsg);
        }
    }
}
