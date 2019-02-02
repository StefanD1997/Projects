using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Zz());
        }

        //Zz
        static double Zz()
        {
            double result;
            const int G = 16137;
            const double cosA = 1;
            const double lp = 1213.65;
            const double l = 2697;
            const double hc = 0.5;
            const double fi = 0.7;
            result = G * cosA * (lp / (l + hc * fi));
            return result;
        }
    }
}
