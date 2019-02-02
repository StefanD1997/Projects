using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._3amax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(amax(0.12114));
            Console.WriteLine(amax(0.13053));
            Console.WriteLine(amax(0.13991));
            Console.WriteLine(amax(0.14930));
            Console.WriteLine(amax(0.15871));
            Console.WriteLine(amax(0.16811));
        }

        static double amax(double D0max)
        {
            double amax;
            const double f = 0.013;
            const double g = 9.81;
            const int б = 1;
            amax = (D0max - f) * (g / б) * 10;
            return amax;
        }
    }
}
