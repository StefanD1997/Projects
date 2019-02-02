using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NewString("w3resource"));
            Console.WriteLine(NewString("Python"));
            Console.WriteLine(NewString("x"));
        }

        //create a new string from a given string where the first and last characters will change their positions
        static string NewString(string str)
        {
            var firstChar = str.Substring(0, 1);
            var lastChar = str.Substring(str.Length - 1);
            var temp = firstChar;
            firstChar = lastChar;
            lastChar = temp;
            if (str.Length > 1)
            {
                return firstChar + str.Substring(1, str.Length - 2) + lastChar;
            }
            return str;
        }

        //Another Example
        public static string first_last(string ustr)
        {
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
        }
    }
}
