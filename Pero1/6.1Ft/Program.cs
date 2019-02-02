using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1Ft
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Ft());
        }

        static double Ft()
        {
            double Ft;
            const double Шamax = 0.3422;
            const double m = 1645;
            const double g = 9.81;
            Ft = m * g * Шamax;
            return Ft;

        }
    }
}
