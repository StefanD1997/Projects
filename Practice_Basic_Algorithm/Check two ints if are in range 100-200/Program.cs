using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_two_ints_if_are_in_range_100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckRange100Between200(150, 90));
            Console.WriteLine(CheckRange100Between200(150, 190));
        }

        static bool CheckRange100Between200(int n, int m)
        {
            if ((n >= 100 && n <= 100) || (m >= 100 && m <= 200))
            {
                return true;
            }
            return false;
        }
    }
}
