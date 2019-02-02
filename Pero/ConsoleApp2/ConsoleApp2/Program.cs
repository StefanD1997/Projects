using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(104.6));
            Console.WriteLine(Sum(156.9));
            Console.WriteLine(Sum(209.2));
            Console.WriteLine("////");
            Console.WriteLine(Sum(235.5));
            Console.WriteLine(Sum(261.5));
            Console.WriteLine(Sum(313.8));
            Console.WriteLine(Sum(366.1));
            Console.WriteLine(Sum(418.4));
            Console.WriteLine(Sum(471));
            Console.WriteLine(Sum(523));
            Console.WriteLine(Sum(575.3));
            Console.WriteLine(Sum(627.6));
            Console.ReadKey();
        }

        static double Sum(double We)
        {
            const int Pemax = 95;
            const double C1 = 1.04915;
            const double C2 = 0.96;
            const double WePemax = 627.6;
            double Pe = 0;
            Pe = Pemax * (C1 * We / WePemax + C2 * Math.Pow(We / WePemax, 2) - Math.Pow(We / WePemax, 3));
            return Pe;
        }

        static double Sum(int We)
        {
            const int Pemax = 95;
            const double C1 = 1.04915;
            const double C2 = 0.96;
            const double WePemax = 627.6;
            double Pe = 0;
            Pe = Pemax * (C1 * We / WePemax + C2 * Math.Pow(We / WePemax, 2) - Math.Pow(We / WePemax, 3));
            return Pe;
        }
    }
}
