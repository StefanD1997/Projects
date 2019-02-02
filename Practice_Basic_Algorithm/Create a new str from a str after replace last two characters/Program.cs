using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_str_from_a_str_after_replace_last_two_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("Python"));
            Console.WriteLine(test("PHP"));
            Console.WriteLine(test("JS"));
            Console.WriteLine(test("C"));
            Console.WriteLine(test("Hello"));
        }

        //create a new string from a given string after swapping last two characters
        public static string test(string s1)
        {
            if (s1.Length > 1)
            {
                return s1.Substring(0, s1.Length - 2) + s1[s1.Length - 1] + s1[s1.Length - 2];
            }
            else
            {
                return s1;
            }
        }
    }
}
