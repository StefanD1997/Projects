using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_from_a_given_string_first_chars_are_A
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Hello";
            Console.WriteLine(x.Substring(2));
            Console.WriteLine(CreatString("abcab"));
            Console.WriteLine(CreatString("python"));
            Console.WriteLine(CreatString("aacda"));
            Console.WriteLine(CreatString("jython"));
        }

        //reate a new string from a given string. If the first or first two characters is 'a', return the
        //string without those 'a' characters otherwise return the original given string
        static string CreatString(string str)
        {
            if (str.Length == 1 && str.Substring (0, 1) == "a")
            {
                str.Remove(0, 1);
            }

            if (str.Substring(0, 2) == "aa")
            {
                str = str.Remove(0, 2);
            }

            if (str.Length > 1)
            {
                if (str.Substring(1, 1) == "a")
                {
                    str.Remove(1, 1);
                }
                if (str.Substring(0, 1) == "a")
                {
                    str = str.Remove(0, 1);
                }
            }
            return str;
        }
    }
}
