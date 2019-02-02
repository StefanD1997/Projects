using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_without_the_first_and_last_character2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateNewString("Hello"));
            Console.WriteLine(CreateNewString("Stefan"));
        }

        //create a new string without the first and last character of a given string of any length
        static string CreateNewString(string str)
        {
            return str.Substring(1 , str.Length - 2);
        }
    }
}
