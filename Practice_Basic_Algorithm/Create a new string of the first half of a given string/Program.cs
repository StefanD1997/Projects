using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_of_the_first_half_of_a_given_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateString("Hello"));
            Console.WriteLine(CreateString("Hi"));
            Console.WriteLine(CreateString("Stefan Draganov"));
        }

        //Create a new string of the first half of a given string of even length
        static string CreateString(string str)
        {
            return str.Substring(0, str.Length / 2);
        }
    }
}
