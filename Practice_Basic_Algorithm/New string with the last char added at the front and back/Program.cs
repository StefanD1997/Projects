using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_string_with_the_last_char_added_at_the_front_and_back
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LastCharAddedFrontAndBack("Char"));
            Console.WriteLine(LastCharAddedFrontAndBack("Stefan"));
            Console.WriteLine(LastCharAddedFrontAndBack("1"));
        }

        static string LastCharAddedFrontAndBack(string str)
        {
            return str.Length < 1 ? str : str.Substring(str.Length - 1) + str.Substring(0, str.Length) + str.Substring(str.Length - 1);
        }

        //Another Example
        public static string test(string str)
        {
            var s = str.Substring(str.Length - 1);
            return s + str + s;
        }
    }
}
