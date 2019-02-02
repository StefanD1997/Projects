using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_whether_two_given_integers_range_40_50_both_50_60
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIntsRange40To50Or50To60(40, 50));
            Console.WriteLine(CheckIntsRange40To50Or50To60(48, 50));
            Console.WriteLine(CheckIntsRange40To50Or50To60(0, 70));
        }

        static bool CheckIntsRange40To50Or50To60(int x, int y)
        {
            if (x >= 40 && x <= 50 && y >= 40 && y <= 50)
            {
                return true;
            }
            else if ((x >= 50 && x <= 60 && y >= 50 && y <= 60))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Another Example
        public static bool test(int x, int y)
        {
            return (x >= 40 && x <= 50 && y >= 40 && y <= 50) || (x >= 50 && x <= 60 && y >= 50 && y <= 60);
        }
    }
}
