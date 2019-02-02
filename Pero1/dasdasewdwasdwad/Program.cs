using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dasdasewdwasdwad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RfRvRa(209.7, 0, 0));
        }

        static double RfRvRa(double Rf, double Rv, double Ra)
        {
            double result;
            result = (Rf + Rv + Ra) / 1000;
            return result;
        }
    }
}
