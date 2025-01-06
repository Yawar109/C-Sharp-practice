using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_by_recursion
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter the height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            //for (int i = height; i >= 1; i--)
            //{
            //    for (int j = 1; j <= height - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}
            for (int i = height; i > 0; i--)
            {
                // Print spaces
                Console.Write(2 + height);

                // Print numbers
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("*");
            }
        }
    }
}
