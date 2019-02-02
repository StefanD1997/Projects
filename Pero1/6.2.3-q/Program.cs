using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._3_q
{
    class Program
    {
        static void Main(string[] args)
        {
            q(3.64);
        }

        static double q(double i1)
        {
            const double q = 1.4389;
            double i2;
            double i3;
            double i4;
            double i5;
            double i6;
            Console.WriteLine("i2 = {0}", i2 = i1 * Math.Pow(q, -1));
            Console.WriteLine("i3 = {0}", i3 = i2 / q);
            Console.WriteLine("i4 = {0}", i4 = i3 / q);
            Console.WriteLine("i5 = {0}", i5 = i4 / q);
            Console.WriteLine("i6 = {0}", i6 = i5 / q);
            return i6;
        }
    }
}
