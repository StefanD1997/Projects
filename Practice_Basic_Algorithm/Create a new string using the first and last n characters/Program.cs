using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_using_the_first_and_last_n_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateString("Hello", 1));
            Console.WriteLine(CreateString("Python", 2));
            Console.WriteLine(CreateString("on", 1));
            Console.WriteLine(CreateString("o", 1));
        }

        //create a new string using the first and last n characters from a given string of length at least n
        static string CreateString(string str, int n)
        {
            if (str.Length > n)
            {
                return str.Substring(0, n) + str.Substring(str.Length - n);
            }
            return str;
        }
    }
}
