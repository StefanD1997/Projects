using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Sminz");
            //Console.WriteLine(Sminz());
            //Console.WriteLine();
            //Console.WriteLine("Sminp");
            //Console.WriteLine(Sminp());
            //Console.WriteLine();
            //Console.WriteLine("Smin");
            //Console.WriteLine(Smin());
            Console.WriteLine("Sminz za Tabela");
            Console.WriteLine(Sminz(2.33449123814835));
            Console.WriteLine(Sminz(2.55518432236475));
            Console.WriteLine(Sminz(2.77588348577803));
            Console.WriteLine(Sminz(2.99657656999442));
            Console.WriteLine(Sminz(3.2172757334077));
            Console.WriteLine(Sminz(3.43797489682097));
            Console.WriteLine(Sminz(3.65866798103737));
            Console.WriteLine(Sminz(3.87936714445064));
            Console.WriteLine(Sminz(4.10006022866704));
            Console.WriteLine("/////////");
            Console.WriteLine("Sminp za Tabela");
            Console.WriteLine(Sminp(2.82556633017289));
            Console.WriteLine(Sminp(3.09536959843837));
            Console.WriteLine(Sminp(3.3651704350251));
            Console.WriteLine(Sminp(3.63497127161182));
            Console.WriteLine(Sminp(4.08715652537646));
            Console.WriteLine(Sminp(4.17458449525934));
            Console.WriteLine(Sminp(4.44438776352482));
            Console.WriteLine(Sminp(4.71418677635248));
            Console.WriteLine(Sminp(4.98399369213609));
            Console.WriteLine("/////////");
            Console.WriteLine("Smin za Tabela");
            Console.WriteLine(Smin(5.03253));
            Console.WriteLine(Smin(5.52303));
            Console.WriteLine(Smin(6.01353));
            Console.WriteLine(Smin(6.50403));
            Console.WriteLine(Smin(6.99453));
            Console.WriteLine(Smin(7.48503));
            Console.WriteLine(Smin(7.97553));
            Console.WriteLine(Smin(8.46603));
            Console.WriteLine(Smin(8.95653));
        }

        //static double Sminz()
        //{
        //    double result;
        //    const double v0 = 56.38;
        //    const double amaxz = 3.217;
        //    result = Math.Pow(v0, 2) / (2 * amaxz);
        //    return result;
        //}

        static double Sminz(double amaxz)
        {
            double result;
            const double v0 = 56.38;
            result = Math.Pow(v0, 2) / (2 * amaxz);
            return result;
        }

        //static double Sminp()
        //{
        //    double result;
        //    const double v0 = 56.38;
        //    const double amaxp = 3.904;
        //    result = Math.Pow(v0, 2) / (2 * amaxp);
        //    return result;
        //}

        static double Sminp(double amaxp)
        {
            double result;
            const double v0 = 56.38;
            result = Math.Pow(v0, 2) / (2 * amaxp);
            return result;
        }

        //static double Smin()
        //{
        //    double result;
        //    const double v0 = 56.38;
        //    const double amax = 6.994;
        //    result = Math.Pow(v0, 2) / (2 * amax);
        //    return result;
        //}

        static double Smin(double amax)
        {
            double result;
            const double v0 = 56.38;
            result = Math.Pow(v0, 2) / (2 * amax);
            return result;
        }
    }
}
