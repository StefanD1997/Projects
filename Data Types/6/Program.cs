using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Function();
        }

        //display certain values of the function x = y2 + 2y + 1 (using integer numbers for y , ranging from -5 to +5)
        static void Function()
        {
            double x;
            Console.WriteLine("Formula : x = y2 + 2y + 1");
            for (int y = -5; y < 6; y++)
            {
                Console.WriteLine(x = Math.Pow(y, 2) + (2 * y) + 1);
            }
        }
    }
}
