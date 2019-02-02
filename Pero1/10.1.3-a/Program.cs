using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1._3_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a Prv Stepen 10 tocka");
            Console.WriteLine(a(0.541, 1.432 ));
            Console.WriteLine(a(0.559, 1.432 ));
            Console.WriteLine(a(0.571, 1.432 ));
            Console.WriteLine(a(0.574, 1.432 ));
            Console.WriteLine(a(0.571, 1.432 ));
            Console.WriteLine(a(0.559, 1.432 ));
            Console.WriteLine(a(0.540, 1.432 ));
            Console.WriteLine(a(0.513, 1.432 ));
            Console.WriteLine(a(0.479, 1.432 ));
            Console.WriteLine(a(0.437, 1.432 ));
            Console.WriteLine(a(0.388, 1.432 ));
            Console.WriteLine("////");
            Console.WriteLine("a Vtor Stepen 10 tocka");
            Console.WriteLine(a(0.279, 1.141));
            Console.WriteLine(a(0.287, 1.141));
            Console.WriteLine(a(0.292, 1.141));
            Console.WriteLine(a(0.292, 1.141));
            Console.WriteLine(a(0.287, 1.141));
            Console.WriteLine(a(0.278, 1.141));
            Console.WriteLine(a(0.264, 1.141));
            Console.WriteLine(a(0.246, 1.141));
            Console.WriteLine(a(0.223, 1.141));
            Console.WriteLine(a(0.196, 1.141));
            Console.WriteLine(a(0.164, 1.141));
            Console.WriteLine("////");
            Console.WriteLine("a Tret Stepen 10 tocka");
            Console.WriteLine(a(0.175, 1.076));
            Console.WriteLine(a(0.179, 1.076));
            Console.WriteLine(a(0.181, 1.076));
            Console.WriteLine(a(0.179, 1.076));
            Console.WriteLine(a(0.174, 1.076));
            Console.WriteLine(a(0.166, 1.076));
            Console.WriteLine(a(0.154, 1.076));
            Console.WriteLine(a(0.139, 1.076));
            Console.WriteLine(a(0.121, 1.076));
            Console.WriteLine(a(0.100, 1.076));
            Console.WriteLine(a(0.075, 1.076));
            Console.WriteLine("////");
            Console.WriteLine("a Cetvrt Stepen 10 tocka");
            Console.WriteLine(a(0.128, 1.057));
            Console.WriteLine(a(0.131, 1.057));
            Console.WriteLine(a(0.132, 1.057));
            Console.WriteLine(a(0.129, 1.057));
            Console.WriteLine(a(0.124, 1.057));
            Console.WriteLine(a(0.116, 1.057));
            Console.WriteLine(a(0.106, 1.057));
            Console.WriteLine(a(0.092, 1.057));
            Console.WriteLine(a(0.076, 1.057));
            Console.WriteLine(a(0.057, 1.057));
            Console.WriteLine(a(0.035, 1.057));
            Console.WriteLine("////");
            Console.WriteLine("a Petti Stepen 10 tocka");
            Console.WriteLine(a(0.105, 1.050));
            Console.WriteLine(a(0.107, 1.050));
            Console.WriteLine(a(0.106, 1.050));
            Console.WriteLine(a(0.104, 1.050));
            Console.WriteLine(a(0.098, 1.050));
            Console.WriteLine(a(0.091, 1.050));
            Console.WriteLine(a(0.081, 1.050));
            Console.WriteLine(a(0.068, 1.050));
            Console.WriteLine(a(0.053, 1.050));
            Console.WriteLine(a(0.035, 1.050));
            Console.WriteLine(a(0.015, 1.050));
            Console.WriteLine("////");
            Console.WriteLine("a Sesti Stepen 10 tocka");
            Console.WriteLine(a(0.087, 1.045));
            Console.WriteLine(a(0.088, 1.045));
            Console.WriteLine(a(0.087, 1.045));
            Console.WriteLine(a(0.084, 1.045));
            Console.WriteLine(a(0.079, 1.045));
            Console.WriteLine(a(0.072, 1.045));
            Console.WriteLine(a(0.062, 1.045));
            Console.WriteLine(a(0.050, 1.045));
            Console.WriteLine(a(0.035, 1.045));
            Console.WriteLine(a(0.019, 1.045));
            Console.WriteLine(a(0.0001, 1.045));
        }

        static double a(double D0, double sigmai)
        {
            double a;
            const double ksi = 0.012;
            const double g = 9.81;
            a = (D0 - ksi) * (g / sigmai);
            return 1 / a;
        }
    }
}
