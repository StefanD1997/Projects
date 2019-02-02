using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_given_nums_are_in_strict_order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckNums(1, 2, 3, false));
            Console.WriteLine(CheckNums(1, 2, 3, true));
            Console.WriteLine(CheckNums(10, 2, 30, false));
            Console.WriteLine(CheckNums(10, 10, 30, true));
        }

        //check if three given numbers are in strict increasing order, such as 4 7 15, or 45, 56, 67, but not 4 ,5, 8 
        //or 6, 6, 8.However,if a fourth parameter  is true, equality is allowed, such as 6, 6, 8 or 7, 7, 7
        static bool CheckNums(int x, int y, int z, bool isTrue)
        {
            if (isTrue)
            {
                if (x <= y && y <= z)
                {
                    return true;
                }
                return false;
            }
            else if (x < y && y < z)
            {
                return true;
            }
            return false;
        }

        //Another Example
        public static bool test(int x, int y, int z, bool flag)
        {
            return flag ? x <= y && y <= z : x < y && y < z;
        }
    }
}
