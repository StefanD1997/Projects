using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(18.7050, 1000));
            Console.WriteLine(Sum(29.1329, 1500));
            Console.WriteLine(Sum(39.83789, 2000));
            Console.WriteLine(Sum(50.49008, 2500));
            Console.WriteLine(Sum(60.7596, 3000));
            Console.WriteLine(Sum(70.31666, 3500));
            Console.WriteLine(Sum(78.83135, 4000));
            Console.WriteLine(Sum(86.01018, 4500));
            Console.WriteLine(Sum(91.41418, 5000));
            Console.WriteLine(Sum(94.82262, 5500));
            Console.WriteLine(Sum(95.86925, 6000));
            Console.ReadKey();
        }

        static double Sum(double Pe, int Vr)
        {
            double Te;
            Te = (Pe * 1000) / ((6.28 * Vr) / 60);
            return Te;
        }

        static double Sum(int Pe, int Vr)
        {
            double Te;
            Te = (Pe * 1000) / ((6.28 * Vr) / 60);
            return Te;
        }
    }
}
