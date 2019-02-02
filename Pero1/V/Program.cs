using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(V(1000));
            Console.WriteLine(V(1500));
            Console.WriteLine(V(2000));
            Console.WriteLine(V(2500));
            Console.WriteLine(V(3000));
            Console.WriteLine(V(3500));
            Console.WriteLine(V(4000));
            Console.WriteLine(V(4500));
            Console.WriteLine(V(5000));
            Console.WriteLine(V(5500));
            Console.WriteLine(V(6000));
        }

        static double V(int Ne)
        {
            double v;
            const double П2 = 6.28;
            const double rd = 0.312;
            const double i6 = 0.59;
            const double i0 = 4.71;
            v = (П2 * rd * (Ne / 60)) / (i6 * i0);
            return v;
        }
    }
}
