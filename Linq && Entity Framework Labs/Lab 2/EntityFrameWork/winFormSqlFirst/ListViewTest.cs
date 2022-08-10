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
    public partial class ListViewTest : Form
    {
        MoviesContext DB = new MoviesContext();
        public ListViewTest()
        {
            InitializeComponent();
            GetDataFromDatabase();
        }

        private void GetDataFromDatabase()
        {
            var data = DB.Movies.Join(DB.Countries, mov => mov.CountryId, con => con.CountryId,
                (m, c) => new { m.Id, m.Rate, Movie = m.Name, Country = c.Name }).ToList();
            //MoviesView.DataSource= data;
            //listView1.da = data.Select(o => new
            //    {Movie = o.Movie, Rate = o.Rate, Country = o.Country}).ToList();
            listView1.View = View.Details;
            listView1.Columns.Add("Id");
            listView1.Columns.Add("Rate");
            listView1.Columns.Add("Movie");
            listView1.Columns.Add("Country");
            foreach (var item in data){
                ListViewItem ListView = new ListViewItem();
                ListView.Text = Convert.ToString(item.Id);
                ListView.SubItems.Add(Convert.ToString(item.Rate));
                ListView.SubItems.Add(item.Movie);
                ListView.SubItems.Add(item.Country);
                listView1.Items.Add(ListView);

            }
         
        }
    }
}
