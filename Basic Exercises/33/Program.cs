using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it is divisiable by 3 or 7");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CheckNum(x));
        }

        // check if a given positive number is a multiple of 3 or a multiple of 7
        static bool CheckNum(int n)
        {
            return n % 3 == 0 || n % 7 == 0;
        }
    }
}
