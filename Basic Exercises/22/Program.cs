using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            int ms = 1000;
            int x;
            Console.Write("x = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(("Checking..."));
            Thread.Sleep(ms);
            Console.WriteLine(CheckInt(x));
        }

        //check if an given integer is within 20 of 100 or 200
        static bool CheckInt(int x)
        {
            return Math.Abs(x - 100) <= 20 || Math.Abs(x - 200) < 20;
        }
    }
}
