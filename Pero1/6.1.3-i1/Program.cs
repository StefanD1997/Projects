using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._3_i1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(i1()); 
        }

        static double i1()
        {
            double i1;
            const double G = 16137;
            const double Шamax = 0.3422;
            const double rd = 0.312;
            const double Temax = 193.50;
            const double nipe = 0.89;
            const double i0 = 4.71;
            i1 = (G * Шamax * rd) / (Temax * nipe * i0);
            return i1;
        }
    }
}
