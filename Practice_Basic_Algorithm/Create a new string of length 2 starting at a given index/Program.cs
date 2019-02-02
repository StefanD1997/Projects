using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_of_length_2_starting_at_a_given_index
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateString("Hello", 1));
            Console.WriteLine(CreateString("Python", 2));
            Console.WriteLine(CreateString("on", 1));
        }

        //create a new string of length 2 starting at the given index of a given string
        static string CreateString(string str, int n)
        {
            if (str.Length > 2)
            {
                return str.Substring(n, 2);
            }
            return str;
        }

        //Another Example
        public static string test(string s1, int index)
        {
            return index + 2 <= s1.Length ? s1.Substring(index, 2) : s1.Substring(0, 2);
        }
    }
}
