using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_using_three_copies_of_the_last_character
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateString("Hello"));
            Console.WriteLine(CreateString("Hi"));
            Console.WriteLine(CreateString("Python"));
        }

        //Create a new string using three copies of the last two character of a given string of length atleast two
        static string CreateString(string str)
        {
            if (str.Length > 1)
            {
                string lastTwo = str.Substring(str.Length - 2);
                return lastTwo + lastTwo + lastTwo;
            }
            return str;
        }
    }
}
