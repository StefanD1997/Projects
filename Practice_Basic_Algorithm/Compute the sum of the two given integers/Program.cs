using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compute_the_sum_of_the_two_given_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(10, 5));
            Console.WriteLine(Sum(10, 50));
        }

        //Compute the sum of the two given integers. If the sum is in the range 10..20 inclusive return 30
        static int Sum(int n, int m)
        {
            if (n + m <= 20 && n + m >= 10)
            {
                return 30;
            }
            return n + m;
        }

        //Another Example
        public static int test(int a, int b)
        {
            return a + b >= 10 && a + b <= 20 ? 30 : a + b;
        }
    }
}
