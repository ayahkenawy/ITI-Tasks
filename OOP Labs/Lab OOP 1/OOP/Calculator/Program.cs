using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {Console.Clear();
                Console.WriteLine("Please Enter First Integer");
                int Finteger = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter Second Integer");
                int Sinteger = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter OPeration + or - or * or /");
                string Operator = Console.ReadLine();
                switch (Operator)
                {
                    case "+":
                        Console.WriteLine(Calculations.Sum(Finteger, Sinteger));
                        break;
                    case "-":
                        Console.WriteLine(Calculations.Minus(Sinteger, Finteger));
                        break;
                    case "*":
                        Console.WriteLine(Calculations.Multi(Finteger, Sinteger));
                        break;
                    case "/":
                        if (Sinteger == 0)
                        {
                            Console.WriteLine("You can't divide by zero");
                        }
                        else
                        {
                            Console.WriteLine(Calculations.Divide(Finteger, Sinteger));
                        }

                        break;
                    default:
                        Console.WriteLine("Please Enter A Right Operator");
                        break;
                }

                Console.WriteLine("Do You Want To Continue yes / no");
            } while (Console.ReadLine() == "yes");
        }
    }
}
