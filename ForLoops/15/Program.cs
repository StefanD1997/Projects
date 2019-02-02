using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            int n = 1;

            for (int i = 25; i > n; i--)
            {
                result = i;
                do
                {
                    result *= i - n;
                    n++;
                } while (n != i);
            }
            Console.WriteLine(result);
        }
    }
}
