using System;
using System.Linq;

namespace EFLapD01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ModelEF DB= new ModelEF();
            DB.Database.EnsureDeleted();
            DB.Database.EnsureCreated();

            #region data


            Country countries1 = new Country { CountryName = "EQYPT" };
            Country countries2 = new Country { CountryName = "KOREA" };
            Country countries3 = new Country { CountryName = "USA" };

            Movie movies1 = new Movie { Name = "Two Girls From Egypt", Rate = 4.5, CountryId = 1 };
            Movie movies2 = new Movie { Name = "Love To Kill", Rate = 5, CountryId = 2 };
            Movie movies3 = new Movie { Name = "The Wolf Of Wall Street", Rate = 3.8, CountryId = 3 };
            Movie movies4 = new Movie { Name = "Catch Me If You Can", Rate = 4.9, CountryId = 3 };
            Movie movies5 = new Movie { Name = "Sad Love Story", Rate = 7, CountryId = 2 };




            DB.Countries.Add(countries1);
            DB.Countries.Add(countries2);
            DB.Countries.Add(countries3);

            DB.Movies.Add(movies1);
            DB.Movies.Add(movies2);
            DB.Movies.Add(movies3);
            DB.Movies.Add(movies4);
            DB.Movies.Add(movies5);


            DB.SaveChanges();

            #endregion


            #region select 

            var q1 = DB.Countries.ToList();
            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }


            var q2 = DB.Movies.ToList();
            foreach (var item in q2)
            {
                Console.WriteLine(item);
            }
            #endregion


            #region update

            var q3 = DB.Movies.SingleOrDefault(item => item.Id == 2);
            q3.Name = "new movie name update";
            q3.Rate = 5;
            DB.SaveChanges();

            var q4 = DB.Movies.ToList();
            #endregion
            foreach (var item in q4)
            {
                Console.WriteLine(item);
            }

            #region delete
            var q5 = DB.Movies.Find(2);
            DB.Remove(q5);
            DB.SaveChanges();
            var q6 = DB.Movies.ToList();
            foreach (var item in q6)
            {
                Console.WriteLine(item);
            }
#endregion
        }
    }
}
