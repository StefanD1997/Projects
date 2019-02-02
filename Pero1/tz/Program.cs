using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So A5 rezultatot = {0}", tz(25));
            Console.WriteLine("So A10 rezultatot = {0}", tz(84));
            Console.WriteLine("So A15 rezultatot = {0}", tz(181));
            Console.WriteLine("So A20 rezultatot = {0}", tz(296));
            Console.WriteLine("So A25 rezultatot = {0}", tz(451));
            Console.WriteLine("So A30 rezultatot = {0}", tz(644));
            Console.WriteLine("So A35 rezultatot = {0}", tz(879));
            Console.WriteLine("So A40 rezultatot = {0}", tz(1150));
            Console.WriteLine("So A45 rezultatot = {0}", tz(1491));
            Console.WriteLine("So A50 rezultatot = {0}", tz(2052));
            Console.WriteLine("So A55 rezultatot = {0}", tz(3334));
        }

        static double tz(double A)
        {
            double result;
            const double Ua = 0.33;
            const double Uv = 0.25;
            result = A * Uv * Ua;
            return result;
        }
    }
}
