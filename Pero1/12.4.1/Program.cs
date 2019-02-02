using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("aMaxz");
            //Console.WriteLine(aMaxz());
            //Console.WriteLine();
            //Console.WriteLine("aMaxp");
            //Console.WriteLine(aMaxp());
            //Console.WriteLine();
            //Console.WriteLine("aMax");
            //Console.WriteLine(aMax());
            Console.WriteLine("aMaxz Tabela");
            Console.WriteLine(aMaxz(3630.35));
            Console.WriteLine(aMaxz(3993.38));
            Console.WriteLine(aMaxz(4356.42));
            Console.WriteLine(aMaxz(4719.45));
            Console.WriteLine(aMaxz(5082.49));
            Console.WriteLine(aMaxz(5445.53));
            Console.WriteLine(aMaxz(5808.56));
            Console.WriteLine(aMaxz(6171.6));
            Console.WriteLine(aMaxz(6534.63));
            Console.WriteLine("//////////");
            Console.WriteLine("aMaxp Tabela");
            Console.WriteLine(aMaxp(4438.146));
            Console.WriteLine(aMaxp(4881.96));
            Console.WriteLine(aMaxp(5325.77));
            Console.WriteLine(aMaxp(5769.58));
            Console.WriteLine(aMaxp(6513.404));
            Console.WriteLine(aMaxp(6657.219));
            Console.WriteLine(aMaxp(7101.033));
            Console.WriteLine(aMaxp(7544.84));
            Console.WriteLine(aMaxp(7988.66));
            Console.WriteLine("//////////");
            Console.WriteLine("aMax Tabela");
            Console.WriteLine(aMax(8068.5));
            Console.WriteLine(aMax(8875.35));
            Console.WriteLine(aMax(9682.2));
            Console.WriteLine(aMax(10489.05));
            Console.WriteLine(aMax(11295.9));
            Console.WriteLine(aMax(12102.75));
            Console.WriteLine(aMax(12909.6));
            Console.WriteLine(aMax(13716.45));
            Console.WriteLine(aMax(14523.3));
        }

        //amaxz
        static double aMaxz()
        {
            double result;
            const double G = 16137;
            const double g = 9.81;
            const double Fkfiz = 5082.495;
            const double f = 0.013;
            result = (g / G) * (Fkfiz + G * f);
            return result;
        }

        static double aMaxz(double Fkfiz)
        {
            double result;
            const double G = 16137;
            const double g = 9.81;
            const double f = 0.013;
            result = (g / G) * (Fkfiz + G * f);
            return result;
        }

        static double aMaxp()
        {
            double result;
            const double G = 16137;
            const double g = 9.81;
            const double Fkfip = 6213.404;
            const double f = 0.013;
            result = (g / G) * (Fkfip + G * f);
            return result;
        }

        static double aMaxp(double Fkfip)
        {
            double result;
            const double G = 16137;
            const double g = 9.81;
            const double f = 0.013;
            result = (g / G) * (Fkfip + G * f);
            return result;
        }

        static double aMax()
        {
            double result;
            const double G = 16137;
            const double g = 9.81;
            const double Fkfi = 11295.9;
            const double f = 0.013;
            result = (g / G) * (Fkfi + G * f);
            return result;
        }

        static double aMax(double Fkfi)
        {
            double result;
            const double G = 16137;
            const double g = 9.81;
            const double f = 0.013;
            result = (g / G) * (Fkfi + G * f);
            return result;
        }
    }
}
