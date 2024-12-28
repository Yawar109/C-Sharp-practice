using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter the height of the triangle: ");
            int height = Convert.ToInt32(Console.ReadLine());

            for (int i = height; i >= 1; i--)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write(".");
                }

                Console.WriteLine();
            }
        }
    }
}
