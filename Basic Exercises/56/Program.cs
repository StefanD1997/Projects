using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfPalindrom("aaa"));
            Console.WriteLine(CheckIfPalindrom("abc"));
            Console.WriteLine(CheckIfPalindrom("madam"));
            Console.WriteLine(CheckIfPalindrom("1234"));
        }

        static bool CheckIfPalindrom(string str)
        {
            char[] c = str.ToCharArray();
            Array.Reverse(c);
            return new string(c).Equals(str);
        }
    }
}
