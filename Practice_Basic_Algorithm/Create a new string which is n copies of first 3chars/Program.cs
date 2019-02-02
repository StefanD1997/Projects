using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_which_is_n_copies_of_first_3chars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CopiesOfFirst3Chars("Hello", 2));
            Console.WriteLine(CopiesOfFirst3Chars("Stefan", 5));
            Console.WriteLine(CopiesOfFirst3Chars("JS", 5));
            Console.WriteLine(CopiesOfFirst3Chars("J", 3));
            Console.WriteLine(CopiesOfFirst3Chars("asuijdhgauywgd", 2));
        }

        static string CopiesOfFirst3Chars(string str, int n)
        {
            if (str.Length > 3)
            {
                string x = string.Concat(Enumerable.Repeat(str.Substring(0, 3), n));
                return x + str.Substring(3, str.Length - 3);
            }
            return string.Concat(Enumerable.Repeat(str, n));
        }

        //Another Example
        public static string test(string s, int n)
        {
            var result = string.Empty;
            var frontOfString = 3;

            if (frontOfString > s.Length)
                frontOfString = s.Length;

            var front = s.Substring(0, frontOfString);

            for (var i = 0; i < n; i++)
            {
                result += front;
            }
            return result;
        }
    }
}
