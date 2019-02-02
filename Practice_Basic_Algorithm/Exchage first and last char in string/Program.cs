using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchage_first_and_last_char_in_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ExchageChars("Hello"));
            Console.WriteLine(ExchageChars("What Is Going On"));
        }

        static string ExchageChars(string str)
        {
            return str.Length > 1
                ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }
    }
}
