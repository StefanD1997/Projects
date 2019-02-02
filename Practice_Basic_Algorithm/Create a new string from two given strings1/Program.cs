using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_from_two_given_strings1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreatString("Hello", "Hi"));
            Console.WriteLine(CreatString("JS", "Python"));
        }

        //Create a new string from two given string one is shorter and another is longer. The format of the new string
        //will be long string + short string + long string
        static string CreatString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str1 + str2 + str1;
            }
            return str2 + str1 + str2;
        }
    }
}
