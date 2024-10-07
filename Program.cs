using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Program to print a pattern
            //for (int i = 1; i <= 11; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Enter the no of row: ");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}

            //-------------------------------------------------

            //Program to print sum of 1st 5 natural numbers
            //int sum = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine($"The sum of 1st 5 natural number is {sum}");

            //-------------------------------------------------

            //Program to print another pattern
            //Console.WriteLine("Enter the no of row: ");
            //int rows = Convert.ToInt32(Console.ReadLine());
            //int a = 1;
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < rows - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k <= i; k++)
            //    {
            //        Console.Write($"{a} ");
            //        ++a;
            //    }
            //    Console.WriteLine();
            //}

            //-------------------------------------------------

            //Program to show the use of break and continue 
            for (int i = 0; i < 50; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                if (i > 19)
                {
                    break;
                }
                Console.Write($"{i * 10} ");
            }


            Console.ReadLine();
        }
    }
}
