using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFLapD01
{
    public class ModelEF:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=FullStackEFD01;Trusted_Connection=true");

        }

        public virtual DbSet<Movie> Movies { get; set; }    
        public virtual DbSet<Country> Countries { get; set; }   
    }
}
