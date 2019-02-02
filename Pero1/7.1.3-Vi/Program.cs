using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._3_Vi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prv Stepen");
            Console.WriteLine(Vi(104.6, 3.64));
            Console.WriteLine(Vi(156.9, 3.64));
            Console.WriteLine(Vi(209.2, 3.64));
            Console.WriteLine(Vi(261.5, 3.64));
            Console.WriteLine(Vi(313.8, 3.64));
            Console.WriteLine(Vi(366.1, 3.64));
            Console.WriteLine(Vi(418.4, 3.64));
            Console.WriteLine(Vi(471, 3.64));
            Console.WriteLine(Vi(523, 3.64));
            Console.WriteLine(Vi(575.3, 3.64));
            Console.WriteLine(Vi(627.6, 3.64));
            Console.WriteLine("////");
            Console.WriteLine("Vtor Stepen");
            Console.WriteLine(Vi(104.6, 1.88));
            Console.WriteLine(Vi(156.9, 1.88));
            Console.WriteLine(Vi(209.2, 1.88));
            Console.WriteLine(Vi(261.5, 1.88));
            Console.WriteLine(Vi(313.8, 1.88));
            Console.WriteLine(Vi(366.1, 1.88));
            Console.WriteLine(Vi(418.4, 1.88));
            Console.WriteLine(Vi(471, 1.88));
            Console.WriteLine(Vi(523, 1.88));
            Console.WriteLine(Vi(575.3, 1.88));
            Console.WriteLine(Vi(627.6, 1.88));
            Console.WriteLine("////");
            Console.WriteLine("Tret Stepen");
            Console.WriteLine(Vi(104.6, 1.18));
            Console.WriteLine(Vi(156.9, 1.18));
            Console.WriteLine(Vi(209.2, 1.18));
            Console.WriteLine(Vi(261.5, 1.18));
            Console.WriteLine(Vi(313.8, 1.18));
            Console.WriteLine(Vi(366.1, 1.18));
            Console.WriteLine(Vi(418.4, 1.18));
            Console.WriteLine(Vi(471, 1.18));
            Console.WriteLine(Vi(523, 1.18));
            Console.WriteLine(Vi(575.3, 1.18));
            Console.WriteLine(Vi(627.6, 1.18));
            Console.WriteLine("////");
            Console.WriteLine("Cetvrt Stepen");
            Console.WriteLine(Vi(104.6, 0.87));
            Console.WriteLine(Vi(156.9, 0.87));
            Console.WriteLine(Vi(209.2, 0.87));
            Console.WriteLine(Vi(261.5, 0.87));
            Console.WriteLine(Vi(313.8, 0.87));
            Console.WriteLine(Vi(366.1, 0.87));
            Console.WriteLine(Vi(418.4, 0.87));
            Console.WriteLine(Vi(471, 0.87));
            Console.WriteLine(Vi(523, 0.87));
            Console.WriteLine(Vi(575.3, 0.87));
            Console.WriteLine(Vi(627.6, 0.87));
            Console.WriteLine("////");
            Console.WriteLine("Petti Stepen");
            Console.WriteLine(Vi(104.6, 0.71));
            Console.WriteLine(Vi(156.9, 0.71));
            Console.WriteLine(Vi(209.2, 0.71));
            Console.WriteLine(Vi(261.5, 0.71));
            Console.WriteLine(Vi(313.8, 0.71));
            Console.WriteLine(Vi(366.1, 0.71));
            Console.WriteLine(Vi(418.4, 0.71));
            Console.WriteLine(Vi(471, 0.71));
            Console.WriteLine(Vi(523, 0.71));
            Console.WriteLine(Vi(575.3, 0.71));
            Console.WriteLine(Vi(627.6, 0.71));
            Console.WriteLine("////");
            Console.WriteLine("Sesti Stepen");
            Console.WriteLine(Vi(104.6, 0.59));
            Console.WriteLine(Vi(156.9, 0.59));
            Console.WriteLine(Vi(209.2, 0.59));
            Console.WriteLine(Vi(261.5, 0.59));
            Console.WriteLine(Vi(313.8, 0.59));
            Console.WriteLine(Vi(366.1, 0.59));
            Console.WriteLine(Vi(418.4, 0.59));
            Console.WriteLine(Vi(471, 0.59));
            Console.WriteLine(Vi(523, 0.59));
            Console.WriteLine(Vi(575.3, 0.59));
            Console.WriteLine(Vi(627.6, 0.59));
        }

        static double Vi(double We, double imi)
        {
            double Vi;
            const double rd = 0.312;
            const double i0 = 4.71;
            Vi = (rd * We) / (i0 * imi);
            return Vi;
        }
    }
}
