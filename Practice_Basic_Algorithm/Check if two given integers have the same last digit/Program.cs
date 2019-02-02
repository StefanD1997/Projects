using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_two_given_integers_have_the_same_last_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfTwoIntsHaveSameLastNumber(20, 45));
            Console.WriteLine(CheckIfTwoIntsHaveSameLastNumber(45, 45));
            Console.WriteLine(CheckIfTwoIntsHaveSameLastNumber(453, 153));
        }

        static bool CheckIfTwoIntsHaveSameLastNumber(int x, int y)
        {
            if (Math.Abs(x % 10) == Math.Abs(y % 10))
            {
                return true;
            }
            return false;
        }
    }
}
