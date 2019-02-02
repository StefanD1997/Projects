using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_str_from_a_given_str_without_first_last_char
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateString("abcab"));
            Console.WriteLine(CreateString("python"));
            Console.WriteLine(CreateString("abcda"));
            Console.WriteLine(CreateString("jython"));
        }

        //create a new string from a given string without the first and last character if the first or last
        //characters are 'a' otherwise return the original given string.
        static string CreateString(string str)
        {
            if (str.Length > 2)
            {
                if (str[0] == 'a' && str[str.Length - 1] == 'a')
                {
                    return str.Substring(1, str.Length - 2);
                }
                else if (str[0] == 'a')
                {
                    return str.Substring(1);
                }
                else if (str[str.Length - 1] == 'a')
                {
                    return str.Substring(0, str.Length - 1);
                }
            }
            else if (str.Length < 2 && str[0] == 'a')
            {
                return str.Substring(1);
            }
            return str;
        }
    }
}
