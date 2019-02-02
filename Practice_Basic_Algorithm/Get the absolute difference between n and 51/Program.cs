using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_the_absolute_difference_between_n_and_51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DifferenceCheck(30));
            Console.WriteLine(DifferenceCheck(53));
        }

        static int DifferenceCheck(int n)
        {
            int x = 51;

            if (n > x)
            {
                return (n - x) * 3;
            }
            return x - n;
        }
    }
}
