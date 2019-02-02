using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
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
            Console.WriteLine(Sum(x, y));
        }

        // compute the sum of two given integers, if two values are equal then return the triple of their sum
        static int Sum(int x, int y)
        {
            if (x == y)
            {
                return (x + y) * 3;
            }
            return x + y;
        }
    }
}
