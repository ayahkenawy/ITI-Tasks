using System;
using System.Linq;
using EntityFrameWork.EntityFWRuntime;
using EntityFrameWork.Models;

namespace EntityFrameWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataContext Db = new DataContext();
            Db.Database.EnsureDeleted();
            Db.Database.EnsureCreated();

            #region Insert

               Country con = new Country(){Name = "USA"};
            Db.Countries.Add(con);
            con = new Country() { Name = "EGYPT"};
            Db.Countries.Add(con);
            con = new Country() { Name = "KOREA"};
            Db.Countries.Add(con);
            Movie mov = new Movie(){Name = "Two Girls From Egypt",Rate = 3,CountryId = 2};
            Db.Add(mov);
            mov = new Movie() { Name = "The Wolf Of Wall Street", Rate = 4, CountryId = 1};
            Db.Add(mov);
            mov = new Movie() {Name = "Catch Me If You Can", Rate = 5, CountryId = 1 };
            Db.Add(mov);
            mov = new Movie() {  Name = "sad Love Story", Rate = 5, CountryId = 3 };
            Db.Add(mov);
            mov = new Movie() {  Name = "Love To Kill", Rate = 5   , CountryId = 3 };
            Db.Add(mov);
            Db.SaveChanges();

            #endregion
         


            #region Select

            var contries = Db.Countries.ToList();
           foreach (var item in contries)
           {
               Console.WriteLine(item);
           }
           var movies = Db.Movies.ToList();
           foreach (var item in movies)
           {
               Console.WriteLine(item);
           }

            #endregion

            #region Update

            var  updateMovie = Db.Movies.SingleOrDefault(m => m.Id == 1);
            updateMovie.Name = "Two Girls From Egypt Updated";
            Db.SaveChanges(); 
            movies = Db.Movies.ToList();
            foreach (var item in movies)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Delete

            var deleteMovie = Db.Movies.Find(5);
            Db.Remove(deleteMovie);
            Db.SaveChanges();
            movies = Db.Movies.ToList();
            foreach (var item in movies)
            {
                Console.WriteLine(item);
            }

            #endregion

        }
    }
}
