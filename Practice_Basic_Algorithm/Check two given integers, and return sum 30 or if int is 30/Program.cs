using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_two_given_integers__and_return_sum_30_or_if_int_is_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIntegers(6, 5));
            Console.WriteLine(CheckIntegers(30, 5));
            Console.WriteLine(CheckIntegers(5, 25));
            Console.WriteLine(CheckIntegers(5, 20));
        }

        static bool CheckIntegers(int a, int b)
        {
            if (a == 30 || b == 30 || a + b == 30)
            {
                return true;
            }
            return false;
        }
    }
}
