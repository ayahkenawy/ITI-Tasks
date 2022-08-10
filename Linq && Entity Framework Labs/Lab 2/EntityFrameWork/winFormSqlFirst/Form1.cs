using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winFormSqlFirst.Context;

namespace winFormSqlFirst
{
    public partial class Form1 : Form
    {
        MoviesContext DB = new MoviesContext();
        public Form1()
        {
            InitializeComponent();
            GetDataFromDatabase();
        }

        private void GetDataFromDatabase()
        {
           
           var data = DB.Movies.Join(DB.Countries, mov => mov.CountryId, con => con.CountryId,
               (m, c) => new {m.Id, m.Rate, Movie = m.Name, Country = c.Name}).ToList();
            //MoviesView.DataSource= data;
            MoviesView.DataSource = data.Select(o => new
                { Movie = o.Movie, Rate = o.Rate,Country=o.Country }).ToList();

        }
    }
}
//Scaffold - DbContext "Server =.;Database = Movies;Trusted_Connection= true"
//Microsoft.EntityFrameworkCore.SqlServer - OutputDir "folderName"