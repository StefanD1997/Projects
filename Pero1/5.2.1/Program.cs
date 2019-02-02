using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Vtmax(2.58));
            Console.WriteLine(Vtmax(2.78));
            Console.WriteLine(Vtmax(2.98));
            Console.WriteLine(Vtmax(3.18));
            Console.WriteLine(Vtmax(3.38));
            Console.WriteLine(Vtmax(3.58));
        }

        static double Vtmax(double ivk)
        {
            double Vtmax;
            const double pi2 = 6.28;
            const double rd = 0.312;
            const int n = 5500;
            Vtmax = (pi2 * n * rd) / (60 * ivk) * 0.1;
            return Vtmax;
        }
    }
}
