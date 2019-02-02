using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            TabelForN(x);
        }

        //display the multiplication table of a given integer
        static void TabelForN(int n)
        {
            int s = 1, result = 0, cnt = 0;
            do
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", n, s, result = n * s);
                    s++;
                    cnt++;
                }
            } while (cnt != 10);
        }
    }
}
