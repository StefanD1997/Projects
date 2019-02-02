using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_whether_three_given_integer_values_are_in_range_20_50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckRange20To50(20, 80, 35));
            Console.WriteLine(CheckRange20To50(10, 80, 150));
        }

        static bool CheckRange20To50(int x, int y, int z)
        {
            if ((x >= 20 && x <= 50) || (y >= 20 && y <= 50) || (z >= 20 && z <= 50))
            {
                return true;
            }
            return false;
        }
    }
}
