using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_a_substring_of_length_2_appears_in_a_given_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountStringFirst2Chars("SteStfanSt"));
            Console.WriteLine(test("StefanSt"));
        }

        static int CountStringFirst2Chars(string str)
        {
            int cnt = 0;
            var x = str.Substring(0, 2);

            if (str.Length > 2 && str.EndsWith(x))
            {
                cnt++;
            }
            else
            {
                return cnt;
            }
            return cnt;
        }

        //Another Example
        public static int test(string str)
        {
            var last_two_char = str.Substring(str.Length - 2);
            var ctr = 0;

            for (var i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 2).Equals(last_two_char)) ctr++;
            }
            return ctr;
        }
    }
}
