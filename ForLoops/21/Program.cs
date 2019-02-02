using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number : ");
            y = Convert.ToInt32(Console.ReadLine());
            sumOfSeries(x, y);
        }

        //display the sum of the series [ 9 + 99 + 999 + 9999 ...]
        static void sumOfSeries(int n, int t)
        {
            double result = 0;
            int x = t;
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                t = t * 10 + x;
                list.Add(t);
                result += t;
            }
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(result);
        }
    }
}
