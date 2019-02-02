using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ivk());
        }

        static double ivk()
        {
            double ivk;
            const double px2 = 6.28;
            const double rd = 0.312;
            const double Vmax = 56.38;
            const int Nevmax = 5500;
            ivk = (px2 * Nevmax * rd) / (Vmax * 60);
            return ivk;
        }
    }
}
