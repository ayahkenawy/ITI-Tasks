using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace LINQtoObject
{
  static public class SampleData
  {
    static public Publisher[] Publishers =
    {
      new Publisher {Name="FunBooks"},
      new Publisher {Name="Joe Publishing"},
      new Publisher {Name="I Publisher"}
    };

    static public Author[] Authors =
    {
      new Author {FirstName="Johnny", LastName="Good"},
      new Author {FirstName="Graziella", LastName="Simplegame"},
      new Author {FirstName="Octavio", LastName="Prince"},
      new Author {FirstName="Jeremy", LastName="Legrand"}
    };

    static public Subject[] Subjects =
    {
      new Subject {Name="Software development"},
      new Subject {Name="Novel"},
      new Subject {Name="Science fiction"}
    };

    static public Book[] Books =
    {
      new Book {
        Title="Funny Stories",
        Publisher=Publishers[0],
        Authors=new[]{Authors[0], Authors[1]},
        PageCount=101,
        Price=25.55M,
        PublicationDate=new DateTime(2004, 11, 10),
        Isbn="0-000-77777-2",
        Subject=Subjects[0]
      },
      new Book {
        Title="LINQ rules",
        Publisher=Publishers[1],
        Authors=new[]{Authors[2]},
        PageCount=300,
        Price=12M,
        PublicationDate=new DateTime(2007, 9, 2),
        Isbn="0-111-77777-2",
        Subject=Subjects[0]
      },
      new Book {
        Title="C# on Rails",
        Publisher=Publishers[1],
        Authors=new[]{Authors[2]},
        PageCount=256,
        Price=35.5M,
        PublicationDate=new DateTime(2007, 4, 1),
        Isbn="0-222-77777-2",
        Subject=Subjects[0]
      },
      new Book {
        Title="The Incredibles",
        Publisher=Publishers[1],
        Authors=new[]{Authors[3]},
        PageCount=1205,
        Price=35.5M,
        PublicationDate=new DateTime(2006, 5, 5),
        Isbn="0-333-77777-2",
        Subject=Subjects[2]
      },
      new Book {
        Title="Bonjour mon Amour",
        Publisher=Publishers[0],
        Authors=new[]{Authors[1], Authors[0]},
        PageCount=50,
        Price=29M,
        PublicationDate=new DateTime(1973, 2, 18),
        Isbn="2-444-77777-2",
        Subject=Subjects[1]
      }
    };

    public static ArrayList GetBooks()
    {
        return new ArrayList(Books);
    }
  }
}