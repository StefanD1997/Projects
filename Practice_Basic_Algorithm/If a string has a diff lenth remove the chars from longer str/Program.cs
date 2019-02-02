using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_a_string_has_a_diff_lenth_remove_the_chars_from_longer_str
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConcatString("abc", "abcd"));
            Console.WriteLine(ConcatString("Python", "Python"));
            Console.WriteLine(ConcatString("JS", "Python"));
        }

        //concat two given strings. If the given strings have different length remove the characters from the longer string
        static string ConcatString(string str, string str2)
        {
            if (str.Length > str2.Length)
            {
                return str.Substring(str.Length - str2.Length) + str2;
            }
            else if (str.Length < str2.Length)
            {
                return str + str2.Substring(str2.Length - str.Length);
            }
            return str + str2;
        }
    }
}
