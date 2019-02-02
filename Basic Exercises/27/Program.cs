using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SumOfDigits(x));
        }

        //compute the sum of the digits of an integer
        static int SumOfDigits(int x)
        {
            int sum = 0;
            while (x != 0)
            {
                sum += x % 10;
                x /= 10;
            }
            return sum;
        }
    }
}
