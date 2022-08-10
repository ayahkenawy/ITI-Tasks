using System;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace Assingments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            //1-largest distance between two identical numbers
            //|1|2|3|1|1|2|5|7|8|9|1|3|2|9|
            //2,3,9,3,10,8,2,0,3

            //int[] nums = { 1, 2, 3, 1, 1, 2, 5, 7, 8, 9, 1, 3, 2, 9 };
            //int highestSpan = 0;
            //Console.WriteLine("Enter An Array Of Numbers Like This 1,2,2,3,5,8 ");
            //int[] nums = Array.ConvertAll(Console.ReadLine().Split(','), s => int.Parse(s));
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i; j < nums.Length; j++)
            //    {
            //        if (nums[i] == nums[j])
            //        {
            //            int span = j - i - 1; // Add 1 to count itself    
            //            highestSpan = Math.Max(highestSpan, span);
            //        }
            //    }
            //}
            //Console.WriteLine(highestSpan);

            #endregion

            #region Task 2

            // 2 - enter a statement      //Hint => use split and join
            // "This is a test"
            // test a is this

            //Console.WriteLine("Enter A Statement");
            //string Statement = Console.ReadLine();
            //string[] arrStatement = Statement.Split(' ');
            //arrStatement = arrStatement.Reverse().ToArray();
            //Console.WriteLine(String.Join(' ', arrStatement));

            #endregion

            #region Task 3

            // 99_999_999
            // in Three Ways
            //Stopwatch s = new Stopwatch();
            //s.Start();
            //s.Stop();
            //Console.WriteLine(s.Elapsed);

            #region First Way

            //int count = 0;
            //Stopwatch s = new Stopwatch();
            //s.Start();
            //for (int i = 1; i < 99999999; i++)
            //{
            //    count += Regex.Matches(i.ToString(), "1").Count;
            //}
            //s.Stop();
            //Console.WriteLine(count);
            //Console.WriteLine(s.Elapsed);


            #endregion

            #region Second Way

            Stopwatch s = new Stopwatch();
            s.Start();
            var count = 0;

            for (int i = 1; i <= 99999999; i++)
            {
                int numberToExamine = i;

                while (numberToExamine > 0)
                {
                    int lastDigit = numberToExamine % 10;
                    if (lastDigit == 1) count++;
                    numberToExamine /= 10;
                }
            }
            s.Stop();
            Console.WriteLine(count);
            Console.WriteLine(s.Elapsed);

            #endregion

            #region Third Way

            //int num = 99999999;
            //int countOfOne = 0;
            //Stopwatch s = new Stopwatch();
            //s.Start();
            //int count = num.ToString().Length;
            //countOfOne = count;
            //for (int i = 1; i < count; i++)
            //{
            //    countOfOne *= 10;
            //}
            //count *= (int)Math.Pow(10, (count - 1));
            //s.Stop();
            //Console.WriteLine(count);
            //Console.WriteLine(countOfOne);
            //Console.WriteLine(s.Elapsed);

            #endregion

            #endregion
        }
    }
}
