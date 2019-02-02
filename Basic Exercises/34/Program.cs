using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence : ");
            string x = Console.ReadLine();
            Console.WriteLine(CheckString(x));
        }

        //check if a string starts with a specified word
        static bool CheckString(string str)
        {
            return str.StartsWith("Hello", StringComparison.OrdinalIgnoreCase);
        }
    }
}
