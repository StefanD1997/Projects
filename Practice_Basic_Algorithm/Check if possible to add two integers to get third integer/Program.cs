using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_possible_to_add_two_integers_to_get_third_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckTwoIntsMatchThird(1, 2, 3));
            Console.WriteLine(CheckTwoIntsMatchThird(1, 2, 8));
            Console.WriteLine(CheckTwoIntsMatchThird(1, 7, 8));
        }

        //Check if it is possible to add two integers to get the third integer from three given integers
        static bool CheckTwoIntsMatchThird(int x, int y, int z)
        {
            if (x + y == z)
            {
                return true;
            }
            return false;
        }

        //Another Example
        public static bool test(int x, int y, int z)
        {
            return x == y + z || y == x + z || z == x + y;
        }
    }
}
