using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            Console.WriteLine("Enter a sentence");
            x = Console.ReadLine();
            Console.WriteLine(NewString(x));
        }

        //create a new string from a given string (length 1 or more ) with the first character added at the front and back
        static string NewString(string str)
        {
            var firstChar = str.Substring(0, 1);
            return firstChar + str + firstChar;
        }
    }
}
