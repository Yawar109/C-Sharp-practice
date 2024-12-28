using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_by_for_loop
{
    internal class Program
    {
        static long Factorial(int n)
        {
            if (n == 0 || n == 1) 
                return 1;
            return n * Factorial(n - 1);
        }
    static void Main()
        {
            Console.WriteLine("enter any number:");

            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number < 0)
                {
                    Console.WriteLine("Factorial is not defined for negative numbers.");
                }
                else
                {
                    long result = Factorial(number);
                    Console.WriteLine(result);
                }
            }
            
        }
    }
}
