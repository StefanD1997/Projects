using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter two numbers");
            Console.WriteLine();
            Console.Write("First Number : ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Second Number : ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(CheckNums(x, y));
        }

        // check two given integers and return true if one is negative and one is positive
        static bool CheckNums(int n, int x)
        {
            return (n < 0 && x > 0 || n > 0 && x < 0);
        }
    }
}
