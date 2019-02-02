using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29
{
    class Program
    {
        static void Main(string[] args)
        {
            ArmstrongNumber(371);
        }

        /*
         * Examples:
        7 = 7^1
        371 = 3^3 + 7^3 + 1^3 (27 + 343 +1)
        8208 = 8^4 + 2^4 +0^4 + 8^4 (4096 + 16 + 0 + 4096).
        1741725 = 1^7 + 7^7 + 4^7 + 1^7 + 7^7 + 2^7 +5^7 (1 + 823543 + 16384 + 1 + 823543 +128 + 78125)*/
        static void ArmstrongNumber(int n)
        {
            int power = n.ToString().Length, num = n;
            double result = 0;
            for (int i = 0; i < power; i++)
            {
                int s = num % 10;
                result += Math.Pow(s, power);
                num /= 10;
            }

            if (result == n)
            {
                Console.WriteLine("{0} is an Armstrong number", n);
            }
            else
            {
                Console.WriteLine("{0} is not an Armstrong number", n);
            }
        }
    }
}
