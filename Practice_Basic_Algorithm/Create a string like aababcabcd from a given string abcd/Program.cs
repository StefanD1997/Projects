using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_string_like_aababcabcd_from_a_given_string_abcd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("abcdr"));
        }

        public static string test(string str)
        {
            var result = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                result += str.Substring(0, i + 1);
            }
            return result;
        }
    }
}
