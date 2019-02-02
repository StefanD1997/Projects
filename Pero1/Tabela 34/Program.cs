using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabela_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skmin fi = 0.6");
            Console.WriteLine(ESovite(5, 6.013));
            Console.WriteLine(ESovite(10, 6.013));
            Console.WriteLine(ESovite(15, 6.013));
            Console.WriteLine(ESovite(20, 6.013));
            Console.WriteLine(ESovite(25, 6.013));
            Console.WriteLine(ESovite(30, 6.013));
            Console.WriteLine(ESovite(35, 6.013));
            Console.WriteLine(ESovite(40, 6.013));
            Console.WriteLine(ESovite(45, 6.013));
            Console.WriteLine(ESovite(50, 6.013));
            Console.WriteLine(ESovite(55, 6.013));
            Console.WriteLine(ESovite(56.38, 6.013));
            Console.WriteLine("//////////");
            Console.WriteLine("Skmin fi = 0.7");
            Console.WriteLine(ESovite(5, 6.994));
            Console.WriteLine(ESovite(10, 6.994));
            Console.WriteLine(ESovite(15, 6.994));
            Console.WriteLine(ESovite(20, 6.994));
            Console.WriteLine(ESovite(25, 6.994));
            Console.WriteLine(ESovite(30, 6.994));
            Console.WriteLine(ESovite(35, 6.994));
            Console.WriteLine(ESovite(40, 6.994));
            Console.WriteLine(ESovite(45, 6.994));
            Console.WriteLine(ESovite(50, 6.994));
            Console.WriteLine(ESovite(55, 6.994));
            Console.WriteLine(ESovite(56.38, 6.994));
            Console.WriteLine("//////////");
            Console.WriteLine("Skmin fi = 0.8");
            Console.WriteLine(ESovite(5, 7.975));
            Console.WriteLine(ESovite(10, 7.975));
            Console.WriteLine(ESovite(15, 7.975));
            Console.WriteLine(ESovite(20, 7.975));
            Console.WriteLine(ESovite(25, 7.975));
            Console.WriteLine(ESovite(30, 7.975));
            Console.WriteLine(ESovite(35, 7.975));
            Console.WriteLine(ESovite(40, 7.975));
            Console.WriteLine(ESovite(45, 7.975));
            Console.WriteLine(ESovite(50, 7.975));
            Console.WriteLine(ESovite(55, 7.975));
            Console.WriteLine(ESovite(56.38, 7.975));
        }

        static double ESovite(double v, double fi)
        {
            double result;
            result = Math.Pow(v, 2) / (2 * fi);
            return result;
        }
    }
}
