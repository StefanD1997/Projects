using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_without_the_first_and_last_character
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateString("Hello"));
            Console.WriteLine(CreateString("Python"));
        }

        //Create a new string without the first and last character of a given string of length atleast two
        static string CreateString(string str)
        {
            if (str.Length > 2)
            {
                return str.Substring(1, str.Length - 2);
            }
            return str;
        }
    }
}
