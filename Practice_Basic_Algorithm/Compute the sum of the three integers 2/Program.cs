using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compute_the_sum_of_the_three_integers_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(4, 5, 7));
            Console.WriteLine(Sum(7, 4, 12));
            Console.WriteLine(Sum(10, 13, 12));
            Console.WriteLine(Sum(17, 12, 18));
        }

        //Compute the sum of the three given integers. However, if any of the values is in the range 10..20 inclusive 
        //then that value counts as 0, except 13 and 17
        public static int Sum(int x, int y, int z)
        {
            return fix_num(x) + fix_num(y) + fix_num(z);
        }
        private static int fix_num(int n)
        {
            return (n < 13 && n > 9) || (n > 17 && n < 21) ? 0 : n;
        }
    }
}
