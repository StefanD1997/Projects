using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CheckTwoNums(x, y));
        }

        //takes two numbers as input and returns true or false when both numbers are even or odd
        static bool CheckTwoNums(int x, int y)
        {
            return (x % 2 == 0 && y % 2 == 0) || (x % 2 != 0 && y % 2 != 0);
        }
    }
}
