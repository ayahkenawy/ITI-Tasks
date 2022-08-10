using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public override string ToString()
        {
            return $"{Id} , {Name} , {Rate} , {Country.Name}";
        }
    }
    
}
