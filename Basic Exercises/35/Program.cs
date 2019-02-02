using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _35
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a second number : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Checking...");
            Thread.Sleep(500);
            Console.WriteLine(CheckNums(x, y));
        }

        //check two given numbers where one is less than 100 and other is greater than 200
        static bool CheckNums(int x, int y)
        {
            return x < 100 && y > 200;
        }
    }
}
