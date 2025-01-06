using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningDebugging
{
    internal class Program
    {
        static void Main()
        {
            char[] letters = { 'S', 't', 'r', 'e', 'a', 'k' };
            string name = "";
            int[] a = new int[11];
            for (int i = 0; i < letters.Length; i++)
            {
                name += letters[i];
                a[i] = i + 1;
                SendMessage(name, a[i]);
            }
            Console.ReadKey();
        }

        static void SendMessage(string name, int msg)
        {
            Console.WriteLine("Have, " + name + "? Count to " + msg);
        }
    }
}
