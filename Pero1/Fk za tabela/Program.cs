using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fk_za_tabela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fkz tabela");
            Console.WriteLine(Fkz(0.5));
            Console.WriteLine(Fkz(0.55));
            Console.WriteLine(Fkz(0.6));
            Console.WriteLine(Fkz(0.65));
            Console.WriteLine(Fkz(0.7));
            Console.WriteLine(Fkz(0.75));
            Console.WriteLine(Fkz(0.8));
            Console.WriteLine(Fkz(0.85));
            Console.WriteLine(Fkz(0.9));
            Console.WriteLine("///////////");
            Console.WriteLine("Fkp tabela");
            Console.WriteLine(Fkp(0.5));
            Console.WriteLine(Fkp(0.55));
            Console.WriteLine(Fkp(0.6));
            Console.WriteLine(Fkp(0.65));
            Console.WriteLine(Fkp(0.7));
            Console.WriteLine(Fkp(0.75));
            Console.WriteLine(Fkp(0.8));
            Console.WriteLine(Fkp(0.85));
            Console.WriteLine(Fkp(0.9));
            Console.WriteLine("///////////");
            Console.WriteLine("Fk tabela");
            Console.WriteLine(Fk(0.5));
            Console.WriteLine(Fk(0.55));
            Console.WriteLine(Fk(0.6));
            Console.WriteLine(Fk(0.65));
            Console.WriteLine(Fk(0.7));
            Console.WriteLine(Fk(0.75));
            Console.WriteLine(Fk(0.8));
            Console.WriteLine(Fk(0.85));
            Console.WriteLine(Fk(0.9));
        }

        static double Fkz(double fi)
        {
            double result;
            const double Zz = 7260.707;
            result = Zz * fi;
            return result;
        }

        static double Fkp(double fi)
        {
            double result;
            const double Zp = 8876.292;
            result = Zp * fi;
            return result;
        }

        static double Fk(double fi)
        {
            double result;
            const double Z = 16137;
            result = Z * fi;
            return result;
        }
    }
}
