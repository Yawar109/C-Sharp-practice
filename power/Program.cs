using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace power
{
    internal class Program
    {
        //static void Main()
        //{
        //    Console.Write("Enter a number: ");
        //    int N = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 1; i <= N; i++)
        //    {
        //        long result = (long)Math.Pow(N, i);

        //        Console.WriteLine(N + " power " + i + " is: " + result);
        //    }
        //}
        static void Main(string[] args)
        {
            int[] age = { 10, 29, 39, 87, 56, 98 };
            var a = from i in age where i > 20 select i;
            foreach (int item in a)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
