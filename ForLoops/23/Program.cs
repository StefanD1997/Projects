using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            int i;
            Console.Write("Enter a number for x : ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter a number of terms : ");
            i = Convert.ToInt32(Console.ReadLine());
            Series(x, i);

        }

        //display the sum of the series [ 1+x+x^2/2!+x^3/3!+....]
        static void Series(double x, int n)
        {
            double no = 1, sum = 1;
            for (int i = 1; i < n; i++)
            {
                no = no * x / (float)i;
                sum += sum + no;
            }
            Console.WriteLine(sum);
        }
    }
}
