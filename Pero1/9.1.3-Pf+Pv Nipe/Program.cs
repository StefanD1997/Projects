using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1._3_Pf_Pv_Nipe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Za 5");
            Console.WriteLine(PfPv(1.04, 0.05, 4.02));
            Console.WriteLine(PfPv(1.04, 0.05, 8.02));
            Console.WriteLine(PfPv(1.04, 0.05, 11.9));
            Console.WriteLine(PfPv(1.04, 0.05, 15.8));
            Console.WriteLine(PfPv(1.04, 0.05, 19.51));
            Console.WriteLine(PfPv(1.04, 0.05, 23.18));
            Console.WriteLine(PfPv(1.04, 0.05, 26.66));
            Console.WriteLine("////");
            Console.WriteLine("Za 10");
            Console.WriteLine(PfPv(2.09, 0.39, 8.05));
            Console.WriteLine(PfPv(2.09, 0.39, 16.05));
            Console.WriteLine(PfPv(2.09, 0.39, 23.9));
            Console.WriteLine(PfPv(2.09, 0.39, 31.16));
            Console.WriteLine(PfPv(2.09, 0.39, 39.03));
            Console.WriteLine(PfPv(2.09, 0.39, 46.37));
            Console.WriteLine(PfPv(2.09, 0.39, 53.33));
            Console.WriteLine("////");
            Console.WriteLine("Za 15");
            Console.WriteLine(PfPv(3.17, 1.34, 12.07));
            Console.WriteLine(PfPv(3.17, 1.34, 24.08));
            Console.WriteLine(PfPv(3.17, 1.34, 35.94));
            Console.WriteLine(PfPv(3.17, 1.34, 47.42));
            Console.WriteLine(PfPv(3.17, 1.34, 58.55));
            Console.WriteLine(PfPv(3.17, 1.34, 69.55));
            Console.WriteLine(PfPv(3.17, 1.34, 80));
            Console.WriteLine("////");
            Console.WriteLine("Za 20");
            Console.WriteLine(PfPv(4.26, 3.18, 16.10));
            Console.WriteLine(PfPv(4.26, 3.18, 32.11));
            Console.WriteLine(PfPv(4.26, 3.18, 47.92));
            Console.WriteLine(PfPv(4.26, 3.18, 63.23));
            Console.WriteLine(PfPv(4.26, 3.18, 78.07));
            Console.WriteLine(PfPv(4.26, 3.18, 92.74));
            Console.WriteLine("////");
            Console.WriteLine("Za 25");
            Console.WriteLine(PfPv(5.36, 6.21, 20.12));
            Console.WriteLine(PfPv(5.36, 6.21, 40.13));
            Console.WriteLine(PfPv(5.36, 6.21, 59.90));
            Console.WriteLine(PfPv(5.36, 6.21, 92.74));
            Console.WriteLine("////");
            Console.WriteLine("Za 30");
            Console.WriteLine(PfPv(6.48, 10.7, 24.15));
            Console.WriteLine(PfPv(6.48, 10.7, 48.16));
            Console.WriteLine(PfPv(6.48, 10.7, 71.88));
            Console.WriteLine(PfPv(6.48, 10.7, 94.85));
            Console.WriteLine("////");
            Console.WriteLine("Za 35");
            Console.WriteLine(PfPv(7.67, 17.06, 28.18));
            Console.WriteLine(PfPv(7.67, 17.06, 56.19));
            Console.WriteLine(PfPv(7.67, 17.06, 83.87));
            Console.WriteLine("////");
            Console.WriteLine("Za 40");
            Console.WriteLine(PfPv(8.90, 25.4, 32.20));
            Console.WriteLine(PfPv(8.90, 25.4, 64.22));
            Console.WriteLine("////");
            Console.WriteLine("Za 45");
            Console.WriteLine(PfPv(10.16, 25.4, 36.23));
            Console.WriteLine(PfPv(10.16, 25.4, 72.24));
            Console.WriteLine("////");
            Console.WriteLine("Za 50");
            Console.WriteLine(PfPv(11.46, 49.7, 40.25));
            Console.WriteLine(PfPv(11.46, 49.7, 80.27));
            Console.WriteLine("////");
            Console.WriteLine("Za 55");
            Console.WriteLine(PfPv(12.77, 66.2, 44.28));
            Console.WriteLine(PfPv(12.77, 66.2, 88.30));
            Console.WriteLine("////");
            Console.WriteLine("Za 56.38");
            Console.WriteLine(PfPv(13.37, 71.3, 45.39));
            Console.WriteLine(PfPv(13.37, 71.3, 90.51));
        }

        static double PfPv(double Pf, double Pv, double Pa)
        {
            double PfPv;
            const double nipe = 0.89;
            PfPv = (Pf + Pv + Pa) / nipe;
            return PfPv;
        }
    }
}
