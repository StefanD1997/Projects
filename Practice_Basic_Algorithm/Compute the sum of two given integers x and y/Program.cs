using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compute_the_sum_of_two_given_integers_x_and_y
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckInts(4, 5));
            Console.WriteLine(CheckInts(7, 4));
            Console.WriteLine(CheckInts(10, 10));
        }

        //Compute the sum of two given non-negative integers x and y as long as the sum has the same number of digits as x.
        //If the sum has more digits than x then return x without y
        static int CheckInts(int x, int y)
        {
            if ((x + y).ToString().Length > x.ToString().Length)
            {
                return x;
            }
            return x + y;
        }
    }
}
