using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_string_starts_with_F_or_end_with_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckString("Fibonaci"));
            Console.WriteLine(CheckString("fibonaci"));
            Console.WriteLine(CheckString("SorgB"));
            Console.WriteLine(CheckString("FosdrB"));
        }

        //Check whether a given string starts with "F" or ends with "B". If the string starts with "F" return "Fizz" and return 
        //"Buzz" if it ends with "B" If the string starts with "F" and ends with "B" return "FizzBuzz". In other cases return the 
        //original string.

        static string CheckString(string str)
        {
            if (str.StartsWith("F") && str.EndsWith("B"))
            {
                return "FizzBuzz";
            }
            else if (str.EndsWith("B"))
            {
                return "Buzz";
            }
            else if (str.StartsWith("F"))
            {
                return "Fizz";
            }
            return str;
        }
    }
}
