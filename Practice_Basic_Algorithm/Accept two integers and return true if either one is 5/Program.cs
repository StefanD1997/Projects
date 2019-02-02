using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accept_two_integers_and_return_true_if_either_one_is_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ChekcInts(5, 2));
            Console.WriteLine(ChekcInts(8, 5));
            Console.WriteLine(ChekcInts(8, 10));
            Console.WriteLine(ChekcInts(3, 2));
            Console.WriteLine(ChekcInts(10, 15));
            Console.WriteLine(ChekcInts(105, 100));
        }

        //Accept two integers and return true if either one is 5 or their sum or difference is 5
        static bool ChekcInts(int x, int y)
        {
            if (x == 5 || y == 5)
            {
                return true;
            }
            else if (x + y == 5)
            {
                return true;
            }
            else if (Math.Abs(x - y) == 5 || Math.Abs(y - x) == 5)
            {
                return true;
            }
            return false;
        }

        //Another Example
        public static bool test(int x, int y)
        {
            return x == 5 || y == 5 || x + y == 5 || Math.Abs(x - y) == 5;
        }
    }
}
