using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_a_given_string_contains_between_2_and_4__z_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfStringCointains2to4Z("Heloz"));
            Console.WriteLine(CheckIfStringCointains2to4Z("Helozz"));
            Console.WriteLine(CheckIfStringCointains2to4Z("Helozzz"));
            Console.WriteLine(CheckIfStringCointains2to4Z("Helozzzz"));
            Console.WriteLine(CheckIfStringCointains2to4Z("Hello"));
        }

        //Not Good Example
        static bool CheckIfStringCointains2to4Z(string str)
        {
            if (str.Contains("zz") || str.Contains("zzz") || str.Contains("zzzz"))
            {
                return true;
            }
            return false;
        }

        //Another Example
        public static bool test(string str)
        {
            int ctr = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'z')
                {
                    ctr++;
                }
            }

            return ctr > 1 && ctr < 4;
        }
    }
}
