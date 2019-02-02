using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1_Tabela28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ne1");
            Console.WriteLine(ne(5, 3.64));
            Console.WriteLine(ne(10, 3.64));
            Console.WriteLine("////");
            Console.WriteLine("Ne2");
            Console.WriteLine(ne(5, 1.88));
            Console.WriteLine(ne(10, 1.88));
            Console.WriteLine(ne(15, 1.88));
            Console.WriteLine(ne(20, 1.88));
            Console.WriteLine("////");
            Console.WriteLine("Ne3");
            Console.WriteLine(ne(5, 1.18));
            Console.WriteLine(ne(10, 1.18));
            Console.WriteLine(ne(15, 1.18));
            Console.WriteLine(ne(20, 1.18));
            Console.WriteLine(ne(25, 1.18));
            Console.WriteLine(ne(30, 1.18));
            Console.WriteLine(ne(35, 1.18));
            Console.WriteLine("////");
            Console.WriteLine("Ne4");
            Console.WriteLine(ne(5, 0.87));
            Console.WriteLine(ne(10, 0.87));
            Console.WriteLine(ne(15, 0.87));
            Console.WriteLine(ne(20, 0.87));
            Console.WriteLine(ne(25, 0.87));
            Console.WriteLine(ne(30, 0.87));
            Console.WriteLine(ne(35, 0.87));
            Console.WriteLine(ne(40, 0.87));
            Console.WriteLine(ne(45, 0.87));
            Console.WriteLine("////");
            Console.WriteLine("Ne5");
            Console.WriteLine(ne(5, 0.71));
            Console.WriteLine(ne(10, 0.71));
            Console.WriteLine(ne(15, 0.71));
            Console.WriteLine(ne(20, 0.71));
            Console.WriteLine(ne(25, 0.71));
            Console.WriteLine(ne(30, 0.71));
            Console.WriteLine(ne(35, 0.71));
            Console.WriteLine(ne(40, 0.71));
            Console.WriteLine(ne(45, 0.71));
            Console.WriteLine(ne(50, 0.71));
            Console.WriteLine(ne(55, 0.71));
            Console.WriteLine(ne(56.38, 0.71));
            Console.WriteLine("////");
            Console.WriteLine("Ne6");
            Console.WriteLine(ne(5, 0.59));
            Console.WriteLine(ne(10, 0.59));
            Console.WriteLine(ne(15, 0.59));
            Console.WriteLine(ne(20, 0.59));
            Console.WriteLine(ne(25, 0.59));
            Console.WriteLine(ne(30, 0.59));
            Console.WriteLine(ne(35, 0.59));
            Console.WriteLine(ne(40, 0.59));
            Console.WriteLine(ne(45, 0.59));
            Console.WriteLine(ne(50, 0.59));
            Console.WriteLine(ne(55, 0.59));
            Console.WriteLine(ne(56.38, 0.59));
        }

        static double ne(double v, double i1)
        {
            double ne;
            const double i0 = 4.71;
            const double Pi = 3.14;
            const double rd = 0.312;
            ne = (v * 60 * i0 * i1) / (2 * Pi * rd);
            return ne;
        }
    }
}
