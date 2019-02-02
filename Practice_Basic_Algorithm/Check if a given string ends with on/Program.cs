using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_a_given_string_ends_with_on
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckString("Hello"));
            Console.WriteLine(CheckString("Python"));
            Console.WriteLine(CheckString("on"));
            Console.WriteLine(CheckString("o"));
        }

        //check if a given string ends with "on"
        static bool CheckString(string str)
        {
            return str.EndsWith("on");
        }
    }
}
