using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_larger_value_from_two_positive_integer_range_20_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReturnBiggerIntInRange20To30(25, 24));
            Console.WriteLine(ReturnBiggerIntInRange20To30(0, 25));
            Console.WriteLine(ReturnBiggerIntInRange20To30(20, 28));
            Console.WriteLine(ReturnBiggerIntInRange20To30(78, 50));
        }

        static int ReturnBiggerIntInRange20To30(int n, int y)
        {
            if (n >= 20 && n <= 30 && y >= 20 && y <= 30)
            {
                if (n >= y)
                {
                    return n;
                }
                return y;
            }
            else if (n >= 20 && n <= 30)
            {
                return n;
            }
            else if (y >= 20 && y <= 30)
            {
                return y;
            }
            return 0;
        }
    }
}
