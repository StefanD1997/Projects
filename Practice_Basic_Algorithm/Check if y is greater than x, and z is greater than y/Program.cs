using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_y_is_greater_than_x__and_z_is_greater_than_y
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckInts(2, 5, 8));
            Console.WriteLine(CheckInts(2, 15, 8));
        }

        //Check if y is greater than x, and z is greater than y from three given integers x,y,z
        static bool CheckInts(int x, int y, int z)
        {
            if (y > x && z > y)
            {
                return true;
            }
            return false;
        }

        //Another Example
        public static bool test(int x, int y, int z)
        {
            return x < y && y < z;
        }
    }
}
