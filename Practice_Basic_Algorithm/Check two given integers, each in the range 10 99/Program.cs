using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_two_given_integers__each_in_the_range_10_99
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckInts(15, 55));
            Console.WriteLine(CheckInts(15, 100));
            Console.WriteLine(CheckInts(15, 52));
            Console.WriteLine(CheckInts(11, 21));
            Console.WriteLine(CheckInts(11, 20));
            Console.WriteLine(CheckInts(10, 10));
        }

        //check two given integers, each in the range 10..99. Return true if a digit appears in both numbers,
        //such as the 3 in 13 and 33
        static bool CheckInts(int x, int y)
        {
            if (x >= 10 || x <= 99 && y >= 10 || y <= 99)
            {
                if (x % 10 == y % 10)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        //Another Example
        public static bool test(int x, int y)
        {
            return x / 10 == y / 10 || x / 10 == y % 10 || x % 10 == y / 10 || x % 10 == y % 10;
        }
    }
}
