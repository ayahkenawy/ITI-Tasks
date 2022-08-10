using System;

namespace MathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7.Write a program with a Math class that has four methods: Add, Subtract, Multiply, and Divide,
            //each of which takes two parameters.Call each method from Main().
            //8. Modify the program from Exercise 7 so that you do not have to create an instance of Math to call the four methods
            Console.WriteLine(MathC.Add(1, 2));
            Console.WriteLine(MathC.Sub(5, 2));
            Console.WriteLine(MathC.Multiply(3, 4));
            if (MathC.Divide(10, 2) == -1)
            {
                Console.WriteLine("You Can't Divide By 0");
            }
            else
            {
                Console.WriteLine(MathC.Divide(10, 2));
            }
        }
}
}
