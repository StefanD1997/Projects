using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter two numbers");
            Console.WriteLine();
            Console.Write("First Number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second Number : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(ChechSum(x, y));
        }

        //check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20
        static bool ChechSum(int x, int y)
        {
            if (x + y == 20)
            {
                return true;
            }
            else if (x == 20 && y != 20)
            {
                return true;
            }
            else if (y == 20 && x != 20)
            {
                return true;
            }
            return false;
        }
    }
}
