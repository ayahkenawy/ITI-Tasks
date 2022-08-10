using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Action_predicate
{
     class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public int DeptId { get; set; }
        public override string ToString()
        {
            return $"{ID}:{Name}:{Age}:{Salary}:{DeptId}";
        }
    }
}
