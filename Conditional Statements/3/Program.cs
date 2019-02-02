using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            PositiveOrNegative(x);
        }

        //check whether a given number is positive or negative
        static void PositiveOrNegative(int x)
        {
            if (x >= 0)
            {
                Console.WriteLine("{0} is a positive number", x);
            }
            else
            {
                Console.WriteLine("{0} is a negative number", x);
            }
        }
    }
}
