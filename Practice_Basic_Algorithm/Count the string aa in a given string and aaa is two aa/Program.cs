using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Count_the_string_aa_in_a_given_string_and_aaa_is_two_aa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("Haa"));
        }

        public static int test(string s)
        {
            int ctr_aa = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s.Substring(i, 2) == "aa")
                {
                    ctr_aa++;
                }
            }
            return ctr_aa;
        }
    }
}
