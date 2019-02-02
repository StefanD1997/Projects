using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prvo");
            Console.WriteLine(v(2.58, 104.6));
            Console.WriteLine(v(2.58, 156.9));
            Console.WriteLine(v(2.58, 209.2));
            Console.WriteLine(v(2.58, 261.5));
            Console.WriteLine(v(2.58, 313.8));
            Console.WriteLine(v(2.58, 366.1));
            Console.WriteLine(v(2.58, 418.4));
            Console.WriteLine(v(2.58, 471));
            Console.WriteLine(v(2.58, 523));
            Console.WriteLine(v(2.58, 575.3));
            Console.WriteLine(v(2.58, 627.6));
            Console.WriteLine("//////////");
            Console.WriteLine("Vtoro");
            Console.WriteLine(v(2.78, 104.6));
            Console.WriteLine(v(2.78, 156.9));
            Console.WriteLine(v(2.78, 209.2));
            Console.WriteLine(v(2.78, 261.5));
            Console.WriteLine(v(2.78, 313.8));
            Console.WriteLine(v(2.78, 366.1));
            Console.WriteLine(v(2.78, 418.4));
            Console.WriteLine(v(2.78, 471));
            Console.WriteLine(v(2.78, 523));
            Console.WriteLine(v(2.78, 575.3));
            Console.WriteLine(v(2.78, 627.6));
            Console.WriteLine("//////////");
            Console.WriteLine("Treto");
            Console.WriteLine(v(2.98, 104.6));
            Console.WriteLine(v(2.98, 156.9));
            Console.WriteLine(v(2.98, 209.2));
            Console.WriteLine(v(2.98, 261.5));
            Console.WriteLine(v(2.98, 313.8));
            Console.WriteLine(v(2.98, 366.1));
            Console.WriteLine(v(2.98, 418.4));
            Console.WriteLine(v(2.98, 471));
            Console.WriteLine(v(2.98, 523));
            Console.WriteLine(v(2.98, 575.3));
            Console.WriteLine(v(2.98, 627.6));
            Console.WriteLine("//////////");
            Console.WriteLine("Cetvrto");
            Console.WriteLine(v(3.18, 104.6));
            Console.WriteLine(v(3.18, 156.9));
            Console.WriteLine(v(3.18, 209.2));
            Console.WriteLine(v(3.18, 261.5));
            Console.WriteLine(v(3.18, 313.8));
            Console.WriteLine(v(3.18, 366.1));
            Console.WriteLine(v(3.18, 418.4));
            Console.WriteLine(v(3.18, 471));
            Console.WriteLine(v(3.18, 523));
            Console.WriteLine(v(3.18, 575.3));
            Console.WriteLine(v(3.18, 627.6));
            Console.WriteLine("//////////");
            Console.WriteLine("Petto");
            Console.WriteLine(v(3.38, 104.6));
            Console.WriteLine(v(3.38, 156.9));
            Console.WriteLine(v(3.38, 209.2));
            Console.WriteLine(v(3.38, 261.5));
            Console.WriteLine(v(3.38, 313.8));
            Console.WriteLine(v(3.38, 366.1));
            Console.WriteLine(v(3.38, 418.4));
            Console.WriteLine(v(3.38, 471));
            Console.WriteLine(v(3.38, 523));
            Console.WriteLine(v(3.38, 575.3));
            Console.WriteLine(v(3.38, 627.6));
            Console.WriteLine("//////////");
            Console.WriteLine("Shesto");
            Console.WriteLine(v(3.58, 104.6));
            Console.WriteLine(v(3.58, 156.9));
            Console.WriteLine(v(3.58, 209.2));
            Console.WriteLine(v(3.58, 261.5));
            Console.WriteLine(v(3.58, 313.8));
            Console.WriteLine(v(3.58, 366.1));
            Console.WriteLine(v(3.58, 418.4));
            Console.WriteLine(v(3.58, 471));
            Console.WriteLine(v(3.58, 523));
            Console.WriteLine(v(3.58, 575.3));
            Console.WriteLine(v(3.58, 627.6));
            Console.WriteLine("//////////");
        }

        static double v(double ivk, double We)
        {
            double v;
            const double rd = 0.312;
            v = We * rd * (1 / ivk);
            return v;
        }

        static double v(double ivk, int We)
        {
            double v;
            const double rd = 0.312;
            v = We * rd * (1 / ivk);
            return v;
        }
    }
}
