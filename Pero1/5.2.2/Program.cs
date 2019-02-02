using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(D0max(6.961));
            Console.WriteLine(D0max(6.460));
            Console.WriteLine(D0max(6.027));
            Console.WriteLine(D0max(5.648));
            Console.WriteLine(D0max(5.313));
            Console.WriteLine(D0max(5.016));
        }

        static double D0max(double VTemax)
        {
            double D0max;
            const double nipe = 0.89;
            const double k = 0.20;
            const double A = 1.99;
            const int G = 16137;
            const double PeTemax = 94.75;
            D0max = (((PeTemax * nipe) / VTemax) - (k * A * Math.Pow(VTemax, 2)) * (1 / G)) / 100;
            return D0max;
        }
    }
}
