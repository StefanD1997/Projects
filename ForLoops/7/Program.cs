using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            TabelFromTo(x);
        }

        //display the multiplication table vertically from 1 to n
        static void TabelFromTo(int n)
        {
            int result, s = 0;
            do
            {
                for (int n1 = 1; n1 <= n; n1++)
                {
                    for (int j = 0; j <= 10; j++)
                    {
                        Console.Write("{0} X {1} = {2}, ", n1, s, result = n1 * s);
                        s++;
                    }
                    Console.WriteLine("\n");
                    s = 0;
                }
            } while (s == n);
        }
    }
}
