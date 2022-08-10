using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCodeFirstWithDB
{
    public partial class Form1 : Form
    {
        FullStackEFD01Context db= new FullStackEFD01Context(); 
        public Form1()
        {
            InitializeComponent();
            fillMoviesToGridView();
        }

        private void fillMoviesToGridView()
        {
            var mov = db.Movies.Join(db.Countries, mov => mov.Country.CountryId, coun => coun.CountryId, (e, d) => new {e.Id, e.Name, d.CountryName }).ToList();
            gridMovies.DataSource = mov;
            //var con = db.Countries.ToList();
            //gridMovies.DataSource = con;

        } 
    }
}
