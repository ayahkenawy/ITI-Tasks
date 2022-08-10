using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFWorkD3.Models
{
    public class Car
    {   
        public int CarId { get; set; }
        public string CarName { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
