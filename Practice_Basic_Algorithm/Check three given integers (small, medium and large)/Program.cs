using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_three_given_integers__small__medium_and_large_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(4, 5, 6));
            Console.WriteLine(Sum(7, 12, 13));
            Console.WriteLine(Sum(-1, 0, 1));
        }

        //Check three given integers (small, medium and large) and return true if the difference between small
        //and medium and the difference between medium and large is same
        static bool Sum(int s, int m, int l)
        {
            if (s > m && s > l && m > l)
            {
                return s - m == m - l;
            }
            else if (s > m && s > l && l > m)
            {
                return s - m == l - m;
            }
            else if (m > s && m > l && s > l)
            {
                return m - s == s - l;
            }
            else if (m > s && m > l && l > s)
            {
                return m - s == l - s;
            }
            else if (l > s && l > m && s > m)
            {
                return l - m == s - m;
            }
            else if (l > s && l > m && m > s)
            {
                return l - m == m - s;
            }
            return false;
        }

        //Antoher Example
        public static bool test(int x, int y, int z)
         {
            if (x > y && x > z && y > z) return x - y == y - z;
            if (x > y && x > z && z > y) return x - z == z - y;
            if (y > x && y > z && x > z) return y - x == x - z;
            if (y > x && y > z && z > x) return y - z == z - x;
            if (z > x && z > y && x > y) return z - x == x - y;
            return z - y == y - x;
         }
    }
}
