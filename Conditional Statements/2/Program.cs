using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            OddOrEven(x);
        }

        //check whether a given number is even or odd
        static void OddOrEven(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("{0} is even", x);
            }
            else
            {
                Console.WriteLine("{0} is odd", x);
            }
        }
    }
}
