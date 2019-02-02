using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_where__if__is_added_to_the_front
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddIfInFront("if else"));
            Console.WriteLine(AddIfInFront("no"));
        }

        static string AddIfInFront(string str)
        {
            if (!str.Contains("if"))
            {
                return "if " + str;
            }
            return str;
        }

        //Another Example
        static string AddIfInFront1(string s)
        {
            if (s.Length > 2 && s.Substring(0, 2).Equals("if"))
            {
                return s;
            }
            return "if " + s;
        }
    }
}
