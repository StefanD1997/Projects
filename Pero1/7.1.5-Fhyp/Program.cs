using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._5_Fhyp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fhyp(5));
            Console.WriteLine(Fhyp(10));
            Console.WriteLine(Fhyp(15));
            Console.WriteLine(Fhyp(20));
            Console.WriteLine(Fhyp(25));
            Console.WriteLine(Fhyp(30));
            Console.WriteLine(Fhyp(35));
            Console.WriteLine(Fhyp(40));
            Console.WriteLine(Fhyp(45));
            Console.WriteLine(Fhyp(50));
            Console.WriteLine(Fhyp(55));
            Console.WriteLine(Fhyp(56.38));
        }

        static double Fhyp(double v)
        {
            double Fhyp;
            const double nipe = 0.89;
            const double Pemax = 95.86;
            Fhyp = (Pemax * nipe) / v;
            return Fhyp;
        }
    }
}
