using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Ftmax(2.58));
            Console.WriteLine(Ftmax(2.78));
            Console.WriteLine(Ftmax(2.98));
            Console.WriteLine(Ftmax(3.18));
            Console.WriteLine(Ftmax(3.38));
            Console.WriteLine(Ftmax(3.58));
        }

        static double Ftmax(double ivk)
        {
            double Ftmax;
            const double nipe = 0.89;
            const double rd = 312;
            const int Temax = 194;
            Ftmax = ((Temax * nipe * ivk) / rd);
            return Ftmax;
        }
    }
}
