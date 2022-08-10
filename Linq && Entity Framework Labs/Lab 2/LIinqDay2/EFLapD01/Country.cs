using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLapD01
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
        public Country()
        {
                Movies = new List<Movie>(); 
        }

        public override string ToString()
        {
            return $"{CountryId}:{CountryName}";
        }
    }
}
