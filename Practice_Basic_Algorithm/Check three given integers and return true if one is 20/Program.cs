using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_three_given_integers_and_return_true_if_one_is_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckInts(10, 20, 30));
            Console.WriteLine(CheckInts(10, 17, 15));
            Console.WriteLine(CheckInts(100, 50, 10));
        }

        //Check three given integers and return true if one of them is 20 or more less than one of the others
        static bool CheckInts(int x, int y, int z)
        {
            if (Math.Abs(x - y) >= 20 || Math.Abs(y - z) >= 20 || Math.Abs(x - z) >= 20)
            {
                return true;
            }
            return false;
        }

        //Another Example
        public static bool test(int x, int y, int z)
        {
            return Math.Abs(x - y) >= 20 || Math.Abs(x - z) >= 20 ||
                     Math.Abs(y - z) >= 20;
        }
    }
}
