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
            //Program to print a pattern
            for (int i = 1; i <= 11; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Enter the no of row: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}
