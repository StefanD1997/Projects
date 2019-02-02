using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Zp());
            Console.WriteLine(Zz());
        }

        //Zp
        static double Zp()
        {
            double result;
            const double G = 16137;
            const double cosA = 1;
            const double lz = 1483.35;
            const double l = 2697;
            const double hc = 0.5;
            const double fi = 0.7;
            result = (G * cosA * lz) / (l - hc * fi);
            return result;
        }

        static double Zz()
        {
            double result;
            const double G = 16137;
            const double cosA = 1;
            const double Zp = 8876.5019;
            result = G * cosA - Zp;
            return result;
        }
    }
}
