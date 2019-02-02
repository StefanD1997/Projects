using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1._2_V_za_tabela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("V Prv Stepen 10 Tocka");
            Console.WriteLine(V(104.6, 3.64));
            Console.WriteLine(V(156.9, 3.64));
            Console.WriteLine(V(209.2, 3.64));
            Console.WriteLine(V(261.5, 3.64));
            Console.WriteLine(V(313.8, 3.64));
            Console.WriteLine(V(366.1, 3.64));
            Console.WriteLine(V(418.4, 3.64));
            Console.WriteLine(V(471, 3.64));
            Console.WriteLine(V(523, 3.64));
            Console.WriteLine(V(575.3, 3.64));
            Console.WriteLine(V(627.6, 3.64));
            Console.WriteLine("////");
            Console.WriteLine("V Vtor Stepen 10 Tocka");
            Console.WriteLine(V(104.6, 1.88));
            Console.WriteLine(V(156.9, 1.88));
            Console.WriteLine(V(209.2, 1.88));
            Console.WriteLine(V(261.5, 1.88));
            Console.WriteLine(V(313.8, 1.88));
            Console.WriteLine(V(366.1, 1.88));
            Console.WriteLine(V(418.4, 1.88));
            Console.WriteLine(V(471, 1.88));
            Console.WriteLine(V(523, 1.88));
            Console.WriteLine(V(575.3, 1.88));
            Console.WriteLine(V(627.6, 1.88));
            Console.WriteLine("////");
            Console.WriteLine("V Tret Stepen 10 Tocka");
            Console.WriteLine(V(104.6, 1.18));
            Console.WriteLine(V(156.9, 1.18));
            Console.WriteLine(V(209.2, 1.18));
            Console.WriteLine(V(261.5, 1.18));
            Console.WriteLine(V(313.8, 1.18));
            Console.WriteLine(V(366.1, 1.18));
            Console.WriteLine(V(418.4, 1.18));
            Console.WriteLine(V(471, 1.18));
            Console.WriteLine(V(523, 1.18));
            Console.WriteLine(V(575.3, 1.18));
            Console.WriteLine(V(627.6, 1.18));
            Console.WriteLine("////");
            Console.WriteLine("V Cetvrta Stepen 10 Tocka");
            Console.WriteLine(V(104.6, 0.87));
            Console.WriteLine(V(156.9, 0.87));
            Console.WriteLine(V(209.2, 0.87));
            Console.WriteLine(V(261.5, 0.87));
            Console.WriteLine(V(313.8, 0.87));
            Console.WriteLine(V(366.1, 0.87));
            Console.WriteLine(V(418.4, 0.87));
            Console.WriteLine(V(471, 0.87));
            Console.WriteLine(V(523, 0.87));
            Console.WriteLine(V(575.3, 0.87));
            Console.WriteLine(V(627.6, 0.87));
            Console.WriteLine("////");
            Console.WriteLine("V Petta Stepen 10 Tocka");
            Console.WriteLine(V(104.6, 0.71));
            Console.WriteLine(V(156.9, 0.71));
            Console.WriteLine(V(209.2, 0.71));
            Console.WriteLine(V(261.5, 0.71));
            Console.WriteLine(V(313.8, 0.71));
            Console.WriteLine(V(366.1, 0.71));
            Console.WriteLine(V(418.4, 0.71));
            Console.WriteLine(V(471, 0.71));
            Console.WriteLine(V(523, 0.71));
            Console.WriteLine(V(575.3, 0.71));
            Console.WriteLine(V(627.6, 0.71));
            Console.WriteLine("////");
            Console.WriteLine("V Sesta Stepen 10 Tocka");
            Console.WriteLine(V(104.6, 0.59));
            Console.WriteLine(V(156.9, 0.59));
            Console.WriteLine(V(209.2, 0.59));
            Console.WriteLine(V(261.5, 0.59));
            Console.WriteLine(V(313.8, 0.59));
            Console.WriteLine(V(366.1, 0.59));
            Console.WriteLine(V(418.4, 0.59));
            Console.WriteLine(V(471, 0.59));
            Console.WriteLine(V(523, 0.59));
            Console.WriteLine(V(575.3, 0.59));
            Console.WriteLine(V(627.6, 0.59));

        }

        static double V(double We, double i)
        {
            double V;
            const double rd = 0.312;
            const double i0 = 4.71;
            V = (rd * We) / (i0 * i);
            return V;
        }
    }
}
