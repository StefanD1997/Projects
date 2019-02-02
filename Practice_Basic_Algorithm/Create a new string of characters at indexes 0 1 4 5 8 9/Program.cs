using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_of_characters_at_indexes_0_1_4_5_8_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("Hello"));
        }

        //Create a new string of the characters at indexes 0,1, 4,5, 8,9 ... from a given string.
        public static string test(string str1)
        {
            var result = string.Empty;
            for (var i = 0; i < str1.Length; i += 4)
            {
                var c = i + 2;
                var n = 0;
                n += c > str1.Length ? 1 : 2;
                result += str1.Substring(i, n);
            }
            return result;
        }
    }
}
