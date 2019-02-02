using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_of_length2_using_first_two_chars_of_str
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateString("Hello"));
            Console.WriteLine(CreateString("Python"));
            Console.WriteLine(CreateString("a"));
            Console.WriteLine(CreateString(""));
        }

        //create a new string of length 2, using first two characters of a given string. If the given string
        //length is less than 2 use '#' as missing characters
        static string CreateString(string str)
        {
            if (str.Length >= 2)
            {
                return str.Substring(0, 2);
            }
            else if (str.Length > 0)
            {
                return str.Substring(0, 1) + "#";
            }
            else
            {
                return str = "##";
            }
        }
    }
}
