using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_the_last_3_characters_of_a_given_string_in_upper_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertLast3Chars("Hello"));
            Console.WriteLine(ConvertLast3Chars("aksdhliawuyhgdilaghwdli"));
            Console.WriteLine(ConvertLast3Chars("asd"));
        }

        static string ConvertLast3Chars(string str)
        {
            if (str.Length > 3)
            {
                return str.Substring(0, str.Length - 3) + str.Substring(str.Length - 3).ToUpper();
            }
            return str.ToUpper();
        }

        //Another Example
        public static string test(string str)
        {
            return str.Length < 3 ? str.ToUpper() : str.Remove(str.Length - 3) + str.Substring(str.Length - 3).ToUpper();
        }
    }
}
