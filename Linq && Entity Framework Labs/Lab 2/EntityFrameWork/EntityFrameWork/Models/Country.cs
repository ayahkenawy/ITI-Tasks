using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Models
{
    public  class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }

        public Country()
        {
            Movies = new HashSet<Movie>();
        }

        public override string ToString()
        {
            return $"{CountryId} , {Name}";
        }
    }
}
