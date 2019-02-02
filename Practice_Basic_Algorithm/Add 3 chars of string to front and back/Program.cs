using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_3_chars_of_string_to_front_and_back
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add_3_Chars_To_Front_And_Back("Python"));
            Console.WriteLine(Add_3_Chars_To_Front_And_Back("Stefan"));
            Console.WriteLine(Add_3_Chars_To_Front_And_Back("Ad"));
        }

        static string Add_3_Chars_To_Front_And_Back(string str)
        {
            if (str.Length > 3)
            {
                var firstChars = str.Substring(0, 3);

                return firstChars + str + firstChars;
            }
            return str + str + str;
        }
    }
}
