using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_using_3_copies_of_the_first_2_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateString("Hello"));
            Console.WriteLine(CreateString("Python"));
            Console.WriteLine(CreateString("J"));
        }

        //create a new string using 3 copies of the first 2 characters of a given string. If the length of the
        //given string is less than 2 use the whole string
        static string CreateString(string str)
        {
            if (str.Length > 2)
            {
                string firstTwoChars = str.Substring(0, 2);
                return string.Concat(Enumerable.Repeat(firstTwoChars, 3));
            }
            return str + str + str;
        }
    }
}
