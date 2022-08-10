using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameWork.Models;
using Microsoft.EntityFrameworkCore;
namespace EntityFrameWork.EntityFWRuntime
{
    public  class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source =.;Initial Catalog = Movies;Integrated Security= true");
            optionsBuilder.UseSqlServer("Server =.;Database = Movies;Trusted_Connection= true");
            //Scaffold - DbContext "ConnectionString"
            //Microsoft.EntityFrameworkCore.SqlServer - OutputDir "folderName"
            //PM > Scaffold - DbContext "Server=.\SQLExpress;Database=SchoolDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer - OutputDir Models
        }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
    }
}
