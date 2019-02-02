using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(UG(1, 12000));
        }

        //Universal Gravitational constant
        //G = 6.6726 x 10-11N-m2/kg2
        static public double UG(double m, double kg)
        {
            double G;

            G = (6.6726 * Math.Pow(10, -11)) - (Math.Pow(m, 2) / (Math.Pow(kg, 2)));
            return G;
        }
    }
}
