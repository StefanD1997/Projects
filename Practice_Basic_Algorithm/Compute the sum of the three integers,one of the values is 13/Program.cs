using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compute_the_sum_of_the_three_integers_one_of_the_values_is_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(4, 5, 7));
            Console.WriteLine(Sum(7, 4, 12));
            Console.WriteLine(Sum(10, 13, 12));
            Console.WriteLine(Sum(13, 12, 18));
        }

        //Compute the sum of the three integers. If one of the values is 13 then do not count it and its right towards the sum.
        static int Sum(int x, int y, int z)
        {
            if (x == 13)
            {
                return 0;
            }
            else if (y == 13)
            {
                return x;
            }
            else if (z == 13)
            {
                return x + y;
            }
            return x + y + z;
        }

        //Another Example
        public static int test(int x, int y, int z)
        {
            if (x == 13) return 0;
            if (y == 13) return x;
            if (z == 13) return x + y;
            return x + y + z;
        }
    }
}
