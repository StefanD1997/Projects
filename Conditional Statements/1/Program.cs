using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
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
            Console.WriteLine(CheckNums(x, y));
        }

        //accept two integers and check whether they are equal or not
        static bool CheckNums(int x, int y)
        {
            return x == y;
        }
    }
}
