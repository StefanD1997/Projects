using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_first_2_char_x4_and_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FourCopiesOfFirstTwoChars("Python"));
            Console.WriteLine(FourCopiesOfFirstTwoChars("D"));
            Console.WriteLine(FourCopiesOfFirstTwoChars("D "));
            Console.WriteLine(Test("Python"));
        }

        static string FourCopiesOfFirstTwoChars(string str)
        {
            if (str.Length > 1)
            {
                var firstTwoChar = str.Substring(0, 2);
                var remainingChars = str.Substring(2, str.Length - 2);

                return firstTwoChar + firstTwoChar + firstTwoChar + firstTwoChar;
            }
            else
            {
                return str;
            }
            
        }

        //Another Example
        public static string Test(string str)
        {
            return str.Length < 2 ? str : str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2);
        }
    }
}
