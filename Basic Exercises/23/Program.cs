using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            Console.WriteLine(NewString(line));
        }

        //convert a given string into lowercase
        static string NewString(string str)
        {
            return str.ToLower();
        }
    }
}
