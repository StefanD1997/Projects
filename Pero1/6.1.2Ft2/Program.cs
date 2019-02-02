using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._2Ft2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Ft2()) ;
        }

        static double Ft2()
        {
            double Ft;
            const double nipe = 0.89;
            const double i1 = 3.64;
            const double i0 = 4.71;
            const double rd = 0.312;
            const double Temax = 193.50;
            Ft = (Temax * nipe * i0 * i1) / rd;
            return Ft;
        }
    }
}
