using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_two_given_integers_and_return_the_value_nearest_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(4, 5));
            Console.WriteLine(Sum(7, 12));
            Console.WriteLine(Sum(10, 13));
            Console.WriteLine(Sum(17, 33));
            Console.WriteLine(Sum(17, 33));
        }

        //Check two given integers and return the value whichever value is nearest to 13 without going over.
        //Return 0 if both numbers go over
        static int Sum(int x, int y)
        {
            const int z = 13;
            if (x > z && y > 13)
            {
                return 0;
            }
            else if (x > z)
            {
                return y;
            }
            else if (y > z)
            {
                return x;
            }
            else if (Math.Abs(z - x) < Math.Abs(z - y))
            {
                return x;
            }
            else
            {
                return y;
            }
        }

        //Another Example
        public static int test(int x, int y)
        {
            if (x > 13 && y > 13) return 0;
            if (x <= 13 && y > 13) return x;
            if (y <= 13 && x > 13) return y;
            return x > y ? x : y;
        }
    }
}
