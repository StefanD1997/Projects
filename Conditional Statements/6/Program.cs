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
            int x;
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            DisplayNum(x);
        }

        //read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0
        static void DisplayNum(int m)
        {
            if (m > 0)
            {
                Console.WriteLine("n = 1");
            }
            else if (m < 0)
            {
                Console.WriteLine("n = -1");
            }
            else
            {
                Console.WriteLine("n = 0");
            }
        }
    }
}
