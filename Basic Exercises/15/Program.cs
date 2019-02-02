using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveChar("w3resource", 1));
            Console.WriteLine(RemoveChar("w3resource", 9));
            Console.WriteLine(RemoveChar("w3resource", 0));
        }

        static string RemoveChar(string str, int n)
        {
            return str.Remove(n, 1);
        }

        //remove specified a character from a non-empty string using index of a character
    }
}
