using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Zp()); 
        }

        //Zp
        static double Zp()
        {
            double result;
            const double G = 16137;
            const double cosA = 1;
            const double Zz = 7260.7077;
            result = (G * cosA) - Zz;
            return result;
        }
    }
}
