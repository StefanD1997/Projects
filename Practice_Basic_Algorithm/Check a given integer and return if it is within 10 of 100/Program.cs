using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_a_given_integer_and_return_if_it_is_within_10_of_100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Check(95));
            Console.WriteLine(Check(80));
            Console.WriteLine(Check(105));
            Console.WriteLine(Check(150));
            Console.WriteLine(Check(190));
        }

        static bool Check(int x)
        {
            int y = 100;
            int z = 200;

            if (Math.Abs(y - x) <= 10 || Math.Abs(z - x) <= 10)
            {
                return true;
            }
            return false;
        }
    }
}
