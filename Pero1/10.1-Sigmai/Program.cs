using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1_Sigmai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sigmai(3.64));
            Console.WriteLine(Sigmai(1.88));
            Console.WriteLine(Sigmai(1.18));
            Console.WriteLine(Sigmai(0.87));
            Console.WriteLine(Sigmai(0.71));
            Console.WriteLine(Sigmai(0.59));
        }

        static double Sigmai(double i)
        {
            double Sigma;
            const double sigma1 = 0.03;
            const double sigma2 = 0.035;
            Sigma = 1 + (Math.Pow(i, 2) * sigma1) + sigma2;
            return Sigma;
        }
    }
}
