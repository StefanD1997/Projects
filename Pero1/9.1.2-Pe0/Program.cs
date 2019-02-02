using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1._2_Pe0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pe1");
            Console.WriteLine(Pe0(2625));
            Console.WriteLine(Pe0(5250));
            Console.WriteLine("////");
            Console.WriteLine("Pe2");
            Console.WriteLine(Pe0(1355.7692));
            Console.WriteLine(Pe0(2711.5384));
            Console.WriteLine(Pe0(4067.3076));
            Console.WriteLine(Pe0(5423.0769));
            Console.WriteLine("////");
            Console.WriteLine("Pe3");
            Console.WriteLine(Pe0(850.9615));
            Console.WriteLine(Pe0(1701.9230));
            Console.WriteLine(Pe0(2552.8846));
            Console.WriteLine(Pe0(3403.8461));
            Console.WriteLine(Pe0(4254.8076));
            Console.WriteLine(Pe0(5105.7692));
            Console.WriteLine(Pe0(5956.7307));
            Console.WriteLine("////");
            Console.WriteLine("Pe4");
            Console.WriteLine(Pe0(627.4038));
            Console.WriteLine(Pe0(1254.8076));
            Console.WriteLine(Pe0(1882.2115));
            Console.WriteLine(Pe0(2509.6153));
            Console.WriteLine(Pe0(3137.0192));
            Console.WriteLine(Pe0(3764.4230));
            Console.WriteLine(Pe0(4391.8269));
            Console.WriteLine(Pe0(5019.2307));
            Console.WriteLine(Pe0(5646.6346));
            Console.WriteLine("////");
            Console.WriteLine("Pe5");
            Console.WriteLine(Pe0(512.0192));
            Console.WriteLine(Pe0(1024.0384));
            Console.WriteLine(Pe0(1536.0576));
            Console.WriteLine(Pe0(2048.0769));
            Console.WriteLine(Pe0(2560.0961));
            Console.WriteLine(Pe0(3072.1153));
            Console.WriteLine(Pe0(3584.1346));
            Console.WriteLine(Pe0(4096.1538));
            Console.WriteLine(Pe0(4608.1730));
            Console.WriteLine(Pe0(5120.1923));
            Console.WriteLine(Pe0(5632.2115));
            Console.WriteLine(Pe0(5773.5288));
            Console.WriteLine("////");
            Console.WriteLine("Pe6");
            Console.WriteLine(Pe0(425.4807));
            Console.WriteLine(Pe0(850.9615));
            Console.WriteLine(Pe0(1276.4423));
            Console.WriteLine(Pe0(1701.9230));
            Console.WriteLine(Pe0(2127.4038));
            Console.WriteLine(Pe0(2552.8846));
            Console.WriteLine(Pe0(2978.3653));
            Console.WriteLine(Pe0(3403.8461));
            Console.WriteLine(Pe0(3829.3269));
            Console.WriteLine(Pe0(4254.8076));
            Console.WriteLine(Pe0(4680.2884));
            Console.WriteLine(Pe0(4797.7211));
        }

        static double Pe0(double ne)
        {
            double Pe0;
            const double C1 = 0.96;
            const double C2 = 1.04;
            const double MS = 95;
            Pe0 = MS * (C1 * (ne / 5500)) + (C2 * (Math.Pow(ne / 5500, 2)) - (Math.Pow(ne / 5500, 3)));
            return Pe0;
        }
    }
}
