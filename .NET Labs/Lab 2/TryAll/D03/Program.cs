using System;

namespace D03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Design 3D Point Class and Include the basic Constructor(s)

            //2.Override the ToString Function to produce this output
            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(Point3D.ToString());
            //Point Coordinates:   (10, 10, 10)
            //Try to Cast Point3D to string type

            //3.Read from the User the Coordinates for 2 point P1, P2
            //(Check the input, tryPares, Parse, Convert)
            Point3D P = new Point3D(10, 10, 10);
            Console.WriteLine(P.ToString());
            int p1;
            int p2;
           
            do
            {
                Console.WriteLine("Please Enter First Point");
            } while (!int.TryParse(Console.ReadLine(), out p1));

            do
            {
                Console.WriteLine("Please Enter Second Point");
            } while (!int.TryParse(Console.ReadLine(), out p2));

            Point3D Point = new Point3D(p1, p2, 10);
            Console.WriteLine(Point.ToString());
        }
    }
}
