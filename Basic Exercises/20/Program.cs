using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Diff(13, 40));
            Console.WriteLine(Diff(50, 21));
            Console.WriteLine(Diff(0, 23));
        }

        //get the absolute value of the difference between two given numbers. Return double the absolute value of the difference 
        //if the first number is greater than second number
        static int Diff(int x, int y)
        {
            if (x > y)
            {
                return Math.Abs((x - y) * 2);
            }
            return Math.Abs(y - x);
        }
    }
}
