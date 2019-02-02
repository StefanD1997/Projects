using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concat_two_given_string_of_length_atleast_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConcatString("Hello", "Hi"));
            Console.WriteLine(ConcatString("JS", "Python"));
        }

        //Concat two given string of length atleast 1, after removing their first character
        static string ConcatString(string str1, string str2)
        {
            return string.Concat(str1.Substring(1, str1.Length - 1), str2.Substring(1, str2.Length - 1));
        }

        //Another Example
        public static string test(string s1, string s2)
        {
            return s1.Substring(1) + s2.Substring(1);
        }
    }
}
