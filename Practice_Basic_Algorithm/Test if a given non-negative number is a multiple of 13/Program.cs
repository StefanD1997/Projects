using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_if_a_given_non_negative_number_is_a_multiple_of_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test(13));
            Console.WriteLine(test(17));
            Console.WriteLine(test(7));
        }

        public static bool test(int n)
        {
            return n % 13 == 0 || n % 13 == 1;
        }
    }
}
