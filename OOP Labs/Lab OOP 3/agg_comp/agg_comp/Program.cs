using System;

namespace agg_comp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Comp

            //Tringle tri = new Tringle();
            //Console.WriteLine(tri.PrintDetails());
           // Geograph geo = new Geograph(10,20);
            //Tringle tri = new Tringle(new Geograph(10,1));
            //Console.WriteLine(tri.PrintDetails());
            Geograph geo = new Geograph(10,20);
            Rectangle rect = new Rectangle(geo);
            Console.WriteLine(rect.PrintDetails());
            #endregion

            #region Agg
            //Geograph geo = new Geograph(10, 20);
            Square squr = new Square(null);
            Square sq = new Square(geo);
            sq.Geo = null;
            Console.WriteLine(rect.PrintDetails());
            #endregion
        }
    }
}
