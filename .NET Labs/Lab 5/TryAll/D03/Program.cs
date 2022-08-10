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
        //    4.Try to use == without overload == operator
        //    If(P1 == P2)
        //    Does it work properly? 
        //    Try to override the Equals Function(from base Object)
        if (Point==P)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not Equal");
        }
        if (Point.Equals(P))
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not Equal");
        }
            //    6. Implement IClonable interface to be able to clone the object.
            //    To implement more than one interface:
            //    class Point3D : IComparable, ICloneable

            Point3D ClonePoint = Point.Clone() as Point3D;
        Console.WriteLine(ClonePoint);
        if (Point.Equals(ClonePoint))
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not Equal");
        }
            //    5. Define array of points: 
            //    Sort this array based on X & Y coordinates
            Point3D[] Points = new Point3D[3] { P, Point, ClonePoint };
        Array.Sort(Points);
        for (int i = 0; i < Points.Length; i++)
        {
            Console.WriteLine(Points[i]);
        }
        }
}
}
