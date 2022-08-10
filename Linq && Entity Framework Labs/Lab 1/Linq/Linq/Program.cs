using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQtoObject;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Display book title and its ISBN.
            var book = SampleData.Books.Select(item => new Book {Isbn = item.Isbn,Title = item.Title});
            Console.WriteLine("Display book title and its ISBN =======>");
            foreach (var item in book)
            {
                Console.Write(item.Isbn +" =====> ");
                Console.WriteLine(item.Title);
            }
            //2 - Display the first 3 books with price more than 25.
            var fBooks = SampleData.Books.Where(item => item.Price>25).Take(3);
            Console.WriteLine("Display the first 3 books with price more than 25 =======>");
            foreach (var item in fBooks)
            {
                Console.WriteLine(item);
            }
            //3 - Display Book title along with its publisher name.
            var bookPublisher = SampleData.Books.Join(SampleData.Publishers, bookpub => bookpub.Publisher.Name, pub => pub.Name, (e, d) => new { e.Title, d.Name });
            Console.WriteLine("Display Book title along with its publisher name =======>");
            foreach (var item in bookPublisher)
            {
                Console.Write(item.Title + " =====> ");
                Console.WriteLine(item.Name);
            }
            //4 - Find the number of books which cost more than 20.
            int bookCount = SampleData.Books.Where(item => item.Price > 20).Count();
            Console.WriteLine("Find the number of books which cost more than 20 =======>");
            Console.WriteLine(bookCount);
            //5 - Display book title, price and subject name sorted by its subject name ascending and by its price descending.
            var booksubject = SampleData.Books
                .Join(SampleData.Subjects, booksub => booksub.Subject.Name, sub => sub.Name, (e, d) => new { e.Title,e.Price, d.Name })
                .OrderBy(b=>b.Name).OrderByDescending(b=>b.Price);
            Console.WriteLine("Display book title, price and subject name sorted by its subject name ascending and by its price descending =======>");
            foreach (var item in booksubject)
            {
                Console.Write(item.Title + " =====> " + item.Price + " =====> ");
                Console.WriteLine(item.Name);
            }
            //6 - Display all subjects with books related to this subject. (Using 2 methods).
            Console.WriteLine("Display all subjects with books related to this subject. (Using 2 methods) =======>");
            Console.WriteLine("Method 1 =======>");
            var subs = from sub in SampleData.Subjects
                join books in SampleData.Books on sub.Name equals books.Subject.Name 
                     group sub by sub.Name;

            foreach (var item in subs)
            {
                Console.WriteLine("* "+item.Key +" *");
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);
                }
            }
            Console.WriteLine("Method 2 =======>");
            var subjects = SampleData.Subjects.Join(SampleData.Books, subjectsub => subjectsub.Name,bookB=>bookB.Subject.Name,(a,b) => new { b.Title, a.Name }).GroupBy(a=>a.Name);
            foreach (var item in subjects)
            {
                Console.WriteLine("* " + item.Key + " *");
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);
                }
            }
            //7 - Display books grouped by publisher &Subject.
            Console.WriteLine("Display books grouped by publisher &Subject =======>");
            var bookGrouped = SampleData.Books
                .GroupBy(x => new { pubName =x.Publisher.Name,subName= x.Subject.Name });
            foreach (var item in bookGrouped)
            {
                Console.WriteLine(item.Key);
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);
                }
            }
            //8 - Ask the user for a Publisher name & sorting method(sorting criteria(by Title, price, etc….) and
            //sorting way(ASC.Or DESC.))…. And
            //implement a function named FindBooksSorted()
            //that displays all books written by this Author sorted as the user requested.
            Console.WriteLine("Number 8 =======>");
            Console.WriteLine("Please enter Publisher Name ?");
            string publisher = Console.ReadLine();
            Console.WriteLine("sorting method(sorting criteria(by 1===>Title, 2===>price)");
            int sortMethod = int.Parse(Console.ReadLine());
            Console.WriteLine("sorting way 1==> ASC.Or 2==> DESC.)");
            int sortWay = int.Parse(Console.ReadLine());
            FindBooksSorted(publisher, sortMethod, sortWay);
            Console.ReadKey();
        }

        public static void FindBooksSorted(string Publisher,int sortMethod,int sortWay)
        {

            //var authBooks = from auth in SampleData.Authors
            //    join books in SampleData.Books on auth.FirstName equals (books.Authors.Where(auth =>
            //        auth.FirstName == authName).FirstOrDefault().FirstName.ToString())
            //    group books by books;
            var publisherBooks = SampleData.Books.Where(item => item.Publisher.Name ==Publisher);

            if (sortMethod==1)
            {
                if (sortWay==1)
                {
                    publisherBooks = SampleData.Books.Where(item => item.Publisher.Name == Publisher).OrderBy(t=>t.Title);
                }
                else
                {
                    publisherBooks = SampleData.Books.Where(item => item.Publisher.Name == Publisher).OrderByDescending(t=>t.Title);
                }
            }
            else
            {
                if (sortWay == 1)
                {
                    publisherBooks = SampleData.Books.Where(item => item.Publisher.Name == Publisher).OrderBy(p=>p.Price);
                }
                else
                {
                    publisherBooks = SampleData.Books.Where(item => item.Publisher.Name == Publisher).OrderByDescending(p => p.Price);
                }
            }
            foreach (var item in publisherBooks)
            {
                Console.WriteLine("Book Title ====> ");
                Console.WriteLine(item);
                Console.WriteLine("Book Authors ====> ");
                foreach (var item2 in item.Authors)
                {
                    string str = item2.FirstName+" "+item2.LastName;
                    Console.WriteLine(str);
                }
            }

        }
    }
}
