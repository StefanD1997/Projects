using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_the_largest_number_among_three_given_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckLargestOfThree(2, 5, 8));
            Console.WriteLine(CheckLargestOfThree(2, 10, 8));
        }

        static int CheckLargestOfThree(int x, int y, int z)
        {
            if (x > y && x > z)
            {
                return x;
            }
            else if (y > x && y > z)
            {
                return y;
            }
            else if (z > x && z > y)
            {
                return z;
            }
            else
            {
                return 0;
            }    
        }

        //Another Example
        public static int test(int x, int y, int z)
        {
            var max = Math.Max(x, Math.Max(y, z));
            return max;
        }
    }
}
