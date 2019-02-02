using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_taking_3_characters_from_the_middle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateString("Hello"));
            Console.WriteLine(CreateString("Python"));
        }

        //create a new string taking 3 characters from the middle of a given string at least 3
        static string CreateString(string str)
        {
            if (str.Length > 3)
            {
                return str.Substring((str.Length - 1) / 2 - 1, 3);
            }
            return str;
        }
    }
}
