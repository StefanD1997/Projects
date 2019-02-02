using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_larger_from_two_given_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckInts(15, 17));
            Console.WriteLine(CheckInts(11, 21));
            Console.WriteLine(CheckInts(11, 20));
            Console.WriteLine(CheckInts(10, 10));
        }

        //find the larger from two given integers. However if the two integers have the same remainder when divided by 7,
        //then the return the smaller integer. If the two integers are the same, return 0
        static int CheckInts(int x, int y)
        {
            if (x == y)
            {
                return 0;
            }
            else if ((x % 7 == y % 7 && x < y || x > y))
            {
                return x;
            }
            else
            {
                return y;
            }
        }
    }
}
