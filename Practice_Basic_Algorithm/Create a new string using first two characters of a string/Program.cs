using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_using_first_two_characters_of_a_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateString("Hello"));
            Console.WriteLine(CreateString("Hi"));
            Console.WriteLine(CreateString("H"));
            Console.WriteLine(CreateString(" "));
        }

        //Create a new string using first two characters of a given string. If the string length is less than 2
        //then return the original string
        static string CreateString(string str)
        {
            if (str.Length > 1)
            {
                string first2 = str.Substring(0, 2);
                return first2;
            }
            return str;
            
        }
    }
}
