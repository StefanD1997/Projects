using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Vgr(10));
            //Console.WriteLine(Vgr(30));
            //Console.WriteLine(Vgr(50));
            //Console.WriteLine(Vgr(70));
            //Console.WriteLine(Vgr(90));
            //Console.WriteLine(Vgr(110));
            //Console.WriteLine(Vgr(130));
            //Console.WriteLine(Vgr(150));
            //Console.WriteLine(Vgr(170));
            //Console.WriteLine(Vgr(190));
            //Console.WriteLine(Vgr(210));
            //Console.WriteLine(Vgr(230));
            //Console.WriteLine(Vgr(250));
            //Console.WriteLine(Vgr1(0.010));
            //Console.WriteLine(Vgr1(0.020));
            //Console.WriteLine(Vgr1(0.030));
            //Console.WriteLine(Vgr1(0.040));
            //Console.WriteLine(Vgr1(0.050));
            //Console.WriteLine(Vgr1(0.060));
            //Console.WriteLine(Vgr1(0.070));
            //Console.WriteLine(Vgr1(0.080));
            //Console.WriteLine(Vgr1(0.090));
            //Console.WriteLine(Vgr1(0.1));
            //Console.WriteLine(Vgr2(10));
            //Console.WriteLine(Vgr2(30));
            //Console.WriteLine(Vgr2(50));
            //Console.WriteLine(Vgr2(70));
            //Console.WriteLine(Vgr2(90));
            //Console.WriteLine(Vgr2(110));
            //Console.WriteLine(Vgr2(130));
            //Console.WriteLine(Vgr2(150));
            //Console.WriteLine(Vgr2(170));
            //Console.WriteLine(Vgr2(190));
            //Console.WriteLine(Vgr2(210));
            //Console.WriteLine(Vgr2(230));
            //Console.WriteLine(Vgr2(250));
            Console.WriteLine(Vgr3(0.010));
            Console.WriteLine(Vgr3(0.020));
            Console.WriteLine(Vgr3(0.030));
            Console.WriteLine(Vgr3(0.040));
            Console.WriteLine(Vgr3(0.050));
            Console.WriteLine(Vgr3(0.060));
            Console.WriteLine(Vgr3(0.070));
            Console.WriteLine(Vgr3(0.080));
            Console.WriteLine(Vgr3(0.090));
            Console.WriteLine(Vgr3(0.1));

        }

        static double Vgr(int R)
        {
            double result;
            const double fi = 0.7;
            const double g = 9.81;
            result = Math.Sqrt(g * R * fi);
            return result;
        }

        static double Vgr1(double B)
        {
            double result;
            const double R = 50;
            const double g = 9.81;
            const double fi = 0.7;
            result = Math.Sqrt((g * (fi + Math.Tan(B)) * R) / (1 - fi * Math.Tan(B)));
            return result;
        }

        static double Vgr2(double R)
        {
            double result;
            const double g = 9.81;
            const double b = 1;
            const double hc = 0.5;
            result = Math.Sqrt((g * R * b) / (2 * hc));
            return result;
        }

        static double Vgr3(double B)
        {
            double result;
            const double g = 9.81;
            const double R = 50;
            const double hc = 0.5;
            const double b = 1;
            result = Math.Sqrt((R * g * (hc * Math.Tan(B) + b / 2) / (hc - (b / 2) * Math.Tan(B))));
            return result;
        }
    }
}
