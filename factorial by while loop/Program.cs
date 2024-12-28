using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial_by_while_loop
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            long factorial = 1;
            int i = 1;

            while (i <= number)
            {
                factorial *= i;
                i++;
            }

            Console.WriteLine(factorial);
        }
    }
}
