using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string : ");
            string x = Console.ReadLine();
            FourCopies(x);
        }

        //create a new string of four copies, taking last four characters from a given string. If the length of the given string is less than 4 return the original one
        static string FourCopies(string str)
        {
            if (str.Length < 4)
            {
                Console.WriteLine(str);
                return str;
            }
            string lastFourChars = str.Substring(str.Length - 4);
            string copied = string.Concat(Enumerable.Repeat(lastFourChars, 4));
            Console.WriteLine(copied);
            return copied;
        }
    }
}
