using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._1_D0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("D0 Prv Stepen");
            Console.WriteLine(D0(8744.7924, 9.95));
            Console.WriteLine(D0(9074.4155, 39.8));
            Console.WriteLine(D0(9306.7166, 89.55));
            Console.WriteLine(D0(9436.3162, 159.2));
            Console.WriteLine(D0(9463.2142, 248.75));
            Console.WriteLine(D0(9386.9216, 358.2));
            Console.WriteLine(D0(9208.4165, 487.5));
            Console.WriteLine(D0(8930.6333, 636.8));
            Console.WriteLine(D0(8542.3236, 805.9));
            Console.WriteLine(D0(8055.2249, 995));
            Console.WriteLine(D0(7465.4245, 1204));
            Console.WriteLine("////");
            Console.WriteLine("D0 Vtor Stepen");
            Console.WriteLine(D0(4516.5411, 9.95));
            Console.WriteLine(D0(4686.7860, 39.8));
            Console.WriteLine(D0(4806.7657, 89.55));
            Console.WriteLine(D0(4873.7017, 159.2));
            Console.WriteLine(D0(4887.5941, 248.75));
            Console.WriteLine(D0(4848.1903, 358.2));
            Console.WriteLine(D0(4755.9953, 487.5));
            Console.WriteLine(D0(4612.5249, 636.8));
            Console.WriteLine(D0(4411.9693, 805.9));
            Console.WriteLine(D0(4160.3908, 995));
            Console.WriteLine(D0(3855.7687, 1204));
            Console.WriteLine("////");
            Console.WriteLine("D0 Tret Stepen");
            Console.WriteLine(D0(2834.8503, 9.95));
            Console.WriteLine(D0(2941.7061, 39.8));
            Console.WriteLine(D0(3017.0125, 89.55));
            Console.WriteLine(D0(3059.0255, 159.2));
            Console.WriteLine(D0(3067.7452, 248.75));
            Console.WriteLine(D0(3043.0130, 358.2));
            Console.WriteLine(D0(2985.1460, 487.5));
            Console.WriteLine(D0(2895.0954, 636.8));
            Console.WriteLine(D0(2769.2148, 805.9));
            Console.WriteLine(D0(2611.3091, 995));
            Console.WriteLine(D0(2420.1101, 1204));
            Console.WriteLine("////");
            Console.WriteLine("D0 Cetvrt Stepen");
            Console.WriteLine(D0(2090.1014, 9.95));
            Console.WriteLine(D0(2168.8850, 39.8));
            Console.WriteLine(D0(2224.4075, 89.55));
            Console.WriteLine(D0(2255.3832, 159.2));
            Console.WriteLine(D0(2261.8121, 248.75));
            Console.WriteLine(D0(2243.5774, 358.2));
            Console.WriteLine(D0(2200.9127, 487.5));
            Console.WriteLine(D0(2134.5195, 636.8));
            Console.WriteLine(D0(2041.7092, 805.9));
            Console.WriteLine(D0(1925.2872, 995));
            Console.WriteLine(D0(1784.3185, 1204));
            Console.WriteLine("////");
            Console.WriteLine("D0 Petti Stepen");
            Console.WriteLine(D0(1705.7150, 9.95));
            Console.WriteLine(D0(1770.0096, 39.8));
            Console.WriteLine(D0(1815.3211, 89.55));
            Console.WriteLine(D0(1840.6001, 159.2));
            Console.WriteLine(D0(1845.8467, 248.75));
            Console.WriteLine(D0(1830.9654, 358.2));
            Console.WriteLine(D0(1796.1471, 487.5));
            Console.WriteLine(D0(1741.9641, 636.8));
            Console.WriteLine(D0(1666.2224, 805.9));
            Console.WriteLine(D0(1571.2114, 995));
            Console.WriteLine(D0(1456.1679, 1204));
            Console.WriteLine("////");
            Console.WriteLine("D0 Sesti Stepen");
            Console.WriteLine(D0(1417.4251, 9.95));
            Console.WriteLine(D0(1470.8530, 39.8));
            Console.WriteLine(D0(1508.5062, 89.55));
            Console.WriteLine(D0(1529.5127, 159.2));
            Console.WriteLine(D0(1533.8726, 248.75));
            Console.WriteLine(D0(1521.5065, 358.2));
            Console.WriteLine(D0(1492.5730, 487.5));
            Console.WriteLine(D0(1447.5477, 636.8));
            Console.WriteLine(D0(1384.6074, 805.9));
            Console.WriteLine(D0(1305.6545, 995));
            Console.WriteLine(D0(1201.0550, 1204));
        }

        static double D0(double Ft, double Rv)
        {
            double D0;
            const double G = 16137;
            D0 = (Ft - Rv) / G;
            return D0;
        }
    }
}
