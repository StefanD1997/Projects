using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_a_given_string_begins_with_abc_or_xyz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckStrting("abc"));
            Console.WriteLine(CheckStrting("abcdef"));
            Console.WriteLine(CheckStrting("C"));
            Console.WriteLine(CheckStrting("xyz"));
            Console.WriteLine(CheckStrting("xyzsder"));
        }

        //check if a given string begins with 'abc' or 'xyz'. If the string begins with 'abc' or 'xyz' return
        //'abc' or 'xyz' otherwise return the empty string
        static string CheckStrting(string str)
        {
            if (str.StartsWith("abc"))
            {
                return "abc";
            }
            if (str.StartsWith("xyz"))
            {
                return "xyz";
            }
            return string.Empty;
        }
    }
}
