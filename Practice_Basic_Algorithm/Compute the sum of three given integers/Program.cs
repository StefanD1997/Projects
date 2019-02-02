using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compute_the_sum_of_three_given_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(4, 5, 7));
            Console.WriteLine(Sum(7, 4, 12));
            Console.WriteLine(Sum(10, 10, 12));
            Console.WriteLine(Sum(12, 12, 18));
        }

        //Compute the sum of three given integers. If the two values are same return the third value.
        static int Sum(int x, int y, int z)
        {
            if (x == y || y == z)
            {
                if (x == y)
                {
                    return z;
                }
                else if (x == z)
                {
                    return y;
                }
                else if (y == z)
                {
                    return x;
                }
                return 0;
            }
            return x + y + z;
        }

        //Another Example
        public static int test(int x, int y, int z)
        {
            if (x == y && y == z) return 0;
            if (x == y) return z;
            if (x == z) return y;
            if (y == z) return x;
            return x + y + z;
        }
    }
}
