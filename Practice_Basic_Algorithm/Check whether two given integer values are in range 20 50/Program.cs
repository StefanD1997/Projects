using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_whether_two_given_integer_values_are_in_range_20_50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckRange20To50TwoInts(20, 60));
            Console.WriteLine(CheckRange20To50TwoInts(20, 30));
            Console.WriteLine(CheckRange20To50TwoInts(0, 200));
        }

        static bool CheckRange20To50TwoInts(int x, int y)
        {
            if ((x >= 20 && x <= 50) || (y >= 20 && y <= 50))
            {
                return true;
            }
            return false;
        }

    }

}
