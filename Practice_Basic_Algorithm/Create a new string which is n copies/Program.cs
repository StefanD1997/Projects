using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_which_is_n_copies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CopiesOfAString("Hello", 6));
            Console.WriteLine(CopiesOfAString("JS", 3));
        }

        static string CopiesOfAString(string str, int n)
        {
            string x = string.Concat(Enumerable.Repeat(str, n));
            return x;
        }

        //Another Example
        public static string test(string s, int n)
        {
            string result = String.Empty;
            for (int i = 0; i < n; i++)
            {
                result += s;
            }
            return result;
        }
    }
}
