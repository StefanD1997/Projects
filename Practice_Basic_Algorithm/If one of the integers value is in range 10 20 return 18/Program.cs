using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_one_of_the_integers_value_is_in_range_10_20_return_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(100, 50));
        }

        //Compute the sum of the two given integers. If one of the given integer value is in the range 10..20 inclusive return 18
        static int Sum(int x, int y)
        {
            if ((x >= 10 && x <= 20) || (y >= 10 && y <= 20))
            {
                return 18;
            }
            return x + y;
        }

        //Another Example
        public static int test(int x, int y)
        {
            return (x >= 10 && x <= 20) || (y >= 10 && y <= 20) ? 18 : x + y;
        }
    }
}
