using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pt(18.705));
            Console.WriteLine(Pt(29.132));
            Console.WriteLine(Pt(39.837));
            Console.WriteLine(Pt(50.490));
            Console.WriteLine(Pt(60.759));
            Console.WriteLine(Pt(70.316));
            Console.WriteLine(Pt(78.831));
            Console.WriteLine(Pt(86.010));
            Console.WriteLine(Pt(91.414));
            Console.WriteLine(Pt(94.822));
            Console.WriteLine(Pt(95.869));
        }

        static double Pt(double Pe)
        {
            double Pt;
            const double nipe = 0.89;
            Pt = Pe * nipe;
            return Pt;
        }
    }
}
