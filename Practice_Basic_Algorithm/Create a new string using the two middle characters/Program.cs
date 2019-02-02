using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_using_the_two_middle_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MiddleTwoChars("Hello"));
            Console.WriteLine(MiddleTwoChars("JS"));
        }

        //create a new string using the two middle characters of a given string of even length(at least 2)
        static string MiddleTwoChars(string str)
        {
            if (str.Length > 2)
            {
                return str.Substring(str.Length / 2 - 1, 2);
            }
            return str;
        }
    }
}
