using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_which_number_nearest_to_value_100_among_two_ints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckWhatNumberIsNearest100(90, 50));
            Console.WriteLine(CheckWhatNumberIsNearest100(90, 101));
            Console.WriteLine(CheckWhatNumberIsNearest100(101, 101));
        }

        static int CheckWhatNumberIsNearest100(int x, int y)
        {
            const int z = 100;

            if (Math.Abs(z - x) > Math.Abs(z - y))
            {
                return y;
            }
            else if (Math.Abs(z - x) < Math.Abs(z - y))
            {
                return x;
            }
            return 0;
        }

        //Another Example
        public static int test(int x, int y)
        {
            const int n = 100;
            var val = Math.Abs(x - n);
            var val2 = Math.Abs(y - n);

            return val == val2 ? 0 : (val < val2 ? x : y);
        }
    }
}
