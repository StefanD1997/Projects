using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_from_a_give_string_where_a_specified_char
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringX("HeHloH", "H"));
        }

        //Create a new string from a give string where a specified character have been removed except starting and ending position of the given string.

        public static string StringX(string str1, string c)
        {
            for (int i = str1.Length - 2; i > 0; i--)
            {
                if (str1[i] == c[0])
                {
                    str1 = str1.Remove(i, 1);
                }
            }

            return str1;
        }
    }
}
