using System;

namespace DurationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());
            Console.WriteLine(D1.GetHashCode());

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());
            Console.WriteLine(D2.GetHashCode());

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());
            Console.WriteLine(D3.GetHashCode());

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());
            Console.WriteLine(D4.GetHashCode());

            Duration obj = new Duration(_hours: 1, _minutes: 20, _seconds: 30);
            Console.WriteLine(obj.ToString());
            Console.WriteLine(obj.GetHashCode());

            Duration obj2 = new Duration { Hours = 1, Minutes = 20, Seconds = 30 };
            Console.WriteLine(obj2.ToString());
            Console.WriteLine(obj2.GetHashCode());

            Duration D5 = new Duration(1, 10, 15);
            Duration D6 = D1 + D5;
            Console.WriteLine(D6.ToString());

            Duration D7 = D1 + 7800;
            Console.WriteLine(D7.ToString());

            Duration D8 = 666 + D3;
            Console.WriteLine(D8.ToString());

            Duration D9 = D1++; //(Increase One Minute)
            Console.WriteLine(D9.ToString());
            Duration D10 = --D2; //(Decrease One Minute)
            Console.WriteLine(D10.ToString());

            if(D1 > D2){ Console.WriteLine("D1 Bigger Than D2"); };
            if(D1 <= D2){ Console.WriteLine("D1 Equal or Bigger Than D2"); };
            if(D1) { Console.WriteLine("D1 Is Not Null"); }  //implicit cast to Boolean  public static implicit operator bool()
        }
    }
}
