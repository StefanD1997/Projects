using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concat_two_given_strings__lowercase_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConcatString("abc", "cat"));
            Console.WriteLine(ConcatString("python", "php"));
            Console.WriteLine(ConcatString("php", "php"));
        }

        //concat two given strings (lowercase). If there are any double character in new string then omit one character
        static string ConcatString(string str, string str2)
        {
            if (str.Length < 1)
            {
                return str;
            }

            if (str2.Length < 1)
            {
                return str2;
            }

            return !str.EndsWith(str2.Substring(0, 1)) ? str + str2 : str + str2.Substring(1);
        }
    }
}
