using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(4, 3);
            Console.WriteLine(rect.CArea());
            Square sq=new Square(20,1);
            Console.WriteLine(sq.CArea());
            Geoshape rec = new Rectangle(4, 3);
            Console.WriteLine(rec.CArea());
            Rectangle squr = new Square(20, 1);
            Console.WriteLine(squr.CArea());
        }
    }
}
