using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._2_Fti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prv Stepen");
            Console.WriteLine(Fti(3.64, 178.81));
            Console.WriteLine(Fti(3.64, 185.55));
            Console.WriteLine(Fti(3.64, 190.30));
            Console.WriteLine(Fti(3.64, 192.95));
            Console.WriteLine(Fti(3.64, 193.50));
            Console.WriteLine(Fti(3.64, 191.94));
            Console.WriteLine(Fti(3.64, 188.29));
            Console.WriteLine(Fti(3.64, 182.61));
            Console.WriteLine(Fti(3.64, 174.67));
            Console.WriteLine(Fti(3.64, 164.71));
            Console.WriteLine(Fti(3.64, 152.65));
            Console.WriteLine("////");
            Console.WriteLine("Vtor Stepen");
            Console.WriteLine(Fti(1.88, 178.81));
            Console.WriteLine(Fti(1.88, 185.55));
            Console.WriteLine(Fti(1.88, 190.30));
            Console.WriteLine(Fti(1.88, 192.95));
            Console.WriteLine(Fti(1.88, 193.50));
            Console.WriteLine(Fti(1.88, 191.94));
            Console.WriteLine(Fti(1.88, 188.29));
            Console.WriteLine(Fti(1.88, 182.61));
            Console.WriteLine(Fti(1.88, 174.67));
            Console.WriteLine(Fti(1.88, 164.71));
            Console.WriteLine(Fti(1.88, 152.65));
            Console.WriteLine("////");
            Console.WriteLine("Tret Stepen");
            Console.WriteLine(Fti(1.18, 178.81));
            Console.WriteLine(Fti(1.18, 185.55));
            Console.WriteLine(Fti(1.18, 190.30));
            Console.WriteLine(Fti(1.18, 192.95));
            Console.WriteLine(Fti(1.18, 193.50));
            Console.WriteLine(Fti(1.18, 191.94));
            Console.WriteLine(Fti(1.18, 188.29));
            Console.WriteLine(Fti(1.18, 182.61));
            Console.WriteLine(Fti(1.18, 174.67));
            Console.WriteLine(Fti(1.18, 164.71));
            Console.WriteLine(Fti(1.18, 152.65));
            Console.WriteLine("////");
            Console.WriteLine("Cetvrt Stepen");
            Console.WriteLine(Fti(0.87, 178.81));
            Console.WriteLine(Fti(0.87, 185.55));
            Console.WriteLine(Fti(0.87, 190.30));
            Console.WriteLine(Fti(0.87, 192.95));
            Console.WriteLine(Fti(0.87, 193.50));
            Console.WriteLine(Fti(0.87, 191.94));
            Console.WriteLine(Fti(0.87, 188.29));
            Console.WriteLine(Fti(0.87, 182.61));
            Console.WriteLine(Fti(0.87, 174.67));
            Console.WriteLine(Fti(0.87, 164.71));
            Console.WriteLine(Fti(0.87, 152.65));
            Console.WriteLine("////");
            Console.WriteLine("Petti Stepen");
            Console.WriteLine(Fti(0.71, 178.81));
            Console.WriteLine(Fti(0.71, 185.55));
            Console.WriteLine(Fti(0.71, 190.30));
            Console.WriteLine(Fti(0.71, 192.95));
            Console.WriteLine(Fti(0.71, 193.50));
            Console.WriteLine(Fti(0.71, 191.94));
            Console.WriteLine(Fti(0.71, 188.29));
            Console.WriteLine(Fti(0.71, 182.61));
            Console.WriteLine(Fti(0.71, 174.67));
            Console.WriteLine(Fti(0.71, 164.71));
            Console.WriteLine(Fti(0.71, 152.65));
            Console.WriteLine("////");
            Console.WriteLine("Sesti Stepen");
            Console.WriteLine(Fti(0.59, 178.81));
            Console.WriteLine(Fti(0.59, 185.55));
            Console.WriteLine(Fti(0.59, 190.30));
            Console.WriteLine(Fti(0.59, 192.95));
            Console.WriteLine(Fti(0.59, 193.50));
            Console.WriteLine(Fti(0.59, 191.94));
            Console.WriteLine(Fti(0.59, 188.29));
            Console.WriteLine(Fti(0.59, 182.61));
            Console.WriteLine(Fti(0.59, 174.67));
            Console.WriteLine(Fti(0.59, 164.71));
            Console.WriteLine(Fti(0.59, 152.65));
        }

        static double Fti(double imi, double Te)
        {
            double Fti;
            const double rd = 312;
            const double i0 = 4.71;
            const double nipe = 0.89;
            Fti = (Te * nipe * i0 * imi) / rd;
            return Fti;
        }
    }
}
