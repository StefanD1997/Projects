using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a sentence : ");
            string x = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(NewStringNoHP(x));
        }

        //check if "HP" appears at second position in a string and returns the string without "HP"
        static string NewStringNoHP(string str)
        {
            if (str.Substring(1, 2) == "HP" || str.Substring(1, 2) == "hp")
            {
                return str.Remove(1, 2);
            }
            else
            {
                return str;
            }
        }
    }
}
