using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_string_made_of_every_other_character
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateAStringOfEveryOtherChar("HaD"));
            Console.WriteLine(CreateAStringOfEveryOtherChar("JavaScript"));
            Console.WriteLine(test("HaD"));
            Console.WriteLine(test("JavaScript"));
            Console.WriteLine(CreateAStringOfEveryOtherChar("S"));
            Console.WriteLine(test("S"));
        }

        static string CreateAStringOfEveryOtherChar(string str)
        {
            string word = "";
            for (int i = 0; i < str.Length; i+=2)
            {
                word += str[i];
            }
            return word.ToString();
        }

        //Another Example
        public static string test(string s)
        {
            var result = string.Empty;
            for (var i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0) result += s[i];
            }
            return result;
        }
    }
}
