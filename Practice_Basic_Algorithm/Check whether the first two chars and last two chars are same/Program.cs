using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_whether_the_first_two_chars_and_last_two_chars_are_same
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckString("abab"));
            Console.WriteLine(CheckString("abcdef"));
            Console.WriteLine(CheckString("xyzsderxy"));
        }

        //check whether the first two characters and last two characters of a given string are same
        static bool CheckString(string str)
        {
            return str.Substring(0, 2) == str.Substring(str.Length - 2);
        }
    }
}
