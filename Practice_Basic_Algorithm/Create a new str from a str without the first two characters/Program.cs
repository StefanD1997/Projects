using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_str_from_a_str_without_the_first_two_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateString("abcab"));
            Console.WriteLine(CreateString("python"));
            Console.WriteLine(CreateString("press"));
            Console.WriteLine(CreateString("jython"));
        }

        //create a new string from a given string without the first two characters. Keep the first character
        //if it is "p" and keep the second character if it is "y"
        static string CreateString(string str)
        {
            if (str[0] == 'p' && str[1] != 'y')
            {
                return str.Substring(0, 1) + str.Substring(2);
            }
            else if (str[0] != 'p' && str[1] == 'y')
            {
                return str.Substring(1);
            }
            else if (str[0] == 'p' && str[1] == 'y')
            {
                return str;
            }
            return str.Substring(2);
        }

        //Another Example
        public static string test(string s1)
        {
            if (s1.Length >= 2)
            {
                if (String.Compare(s1.Substring(1, 1), "y") != 0)
                {
                    s1 = s1.Remove(1, 1);
                }

                if (String.Compare(s1.Substring(0, 1), "p") != 0)
                {
                    s1 = s1.Remove(0, 1);
                }
            }
            else if (s1.Length > 0 && String.Compare(s1.Substring(0, 1), "p") != 0)
            {
                s1 = s1.Remove(0, 1);
            }

            return s1;
        }
    }
}
