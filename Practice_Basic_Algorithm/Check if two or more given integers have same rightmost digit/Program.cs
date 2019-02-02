using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_two_or_more_given_integers_have_same_rightmost_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIfIntsHaveSameDigit(25, 49, 34));
            Console.WriteLine(CheckIfIntsHaveSameDigit(25, 45, 35));
        }

        //Check if two or more non-negative given integers have the same rightmost digit
        static bool CheckIfIntsHaveSameDigit(int x, int y, int z)
        {
            if (x % 10 == y % 10 || y % 10 == z % 10 || x % 10 == z % 10)
            {
                return true;
            }
            return false;
        }
    }
}
