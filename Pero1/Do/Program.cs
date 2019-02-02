using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(18 / 10, 11.281));
            Console.WriteLine(Sum(29 / 10, 17.627));
            Console.WriteLine(Sum(39 / 10, 23.267));
            Console.WriteLine(Sum(50 / 10, 28.908));
            Console.WriteLine(Sum(60 / 10, 35.254));
            Console.WriteLine(Sum(70 / 10, 40.894));
            Console.WriteLine(Sum(78 / 10, 46.535));
            Console.WriteLine(Sum(86 / 10, 52.881));
            Console.WriteLine(Sum(91 / 10, 58.522));
            Console.WriteLine(Sum(94 / 10, 64.162));
            Console.WriteLine(Sum(95 / 10, 70.508));

            //Console.WriteLine(PetaTocka1(3.64, 104.6));
            Console.ReadKey();
        }

        static double Sum(double Pe, double V)
        {
            const double np = 0.89;
            const double k = 0.20;
            const double A = 1.99;
            const int G = 16137;
            double Do;
            Do = ((Pe * np / V) - ((k * A) * Math.Pow(V, 2)) * 1 / G);
            return Do;
        }

        static double Sum(int Pe, int V)
        {
            const double np = 0.89;
            const double k = 0.20;
            const double A = 1.99;
            const int G = 1645;
            double Do;
            Do = ((Pe * np / V) - (k * A * Math.Pow(V, 2)) * 1 / G);
            return Do;
        }

        static double Sum(int Pe, double V)
        {
            const double np = 0.89;
            const double k = 0.20;
            const double A = 1.99;
            const int G = 16137;
            double Do;
            Do = ((Pe * np / V) - (k * A * Math.Pow(V, 2)) * 1 / G);
            return Do;
        }

        static double Sum(double Pe, int V)
        {
            const double np = 0.89;
            const double k = 0.20;
            const double A = 1.99;
            const int G = 16137;
            double Do;
            Do = ((Pe * np / V) - (k * A * Math.Pow(V, 2)) * 1 / G);
            return Do;
        }

        static double PetaTocka(double imp)
        {
            const double ioi = 4.71;
            double ivk;
            ivk = ioi * imp;
            return ivk;
        }

        static double PetaTocka1(double imp, double We)
        {
            const double rd = 0.312;
            const double ioi = 4.17;
            double v;
            v = We * rd * (1 / (ioi * imp));
            return v;
        }

        static double PetaTocka12(double We)
        {
            const double rd = 0.312;
            double v; 
            v = We * rd;
            return v;
        }

        static double PetaTocka12(int We)
        {
            const double rd = 0.312;
            double v;
            v = We * rd;
            return v;
        }


    }
}
