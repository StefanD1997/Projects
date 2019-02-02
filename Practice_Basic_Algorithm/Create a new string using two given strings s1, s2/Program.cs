using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_using_two_given_strings_s1__s2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateString("Hi", "Hello"));
            Console.WriteLine(CreateString("whats", "app"));
        }

        //Create a new string using two given strings s1, s2, the format of the new string will be s1s2s2s1
        static string CreateString(string s1, string s2)
        {
            return s1 + s2 + s2 + s1;
        }
    }
}
