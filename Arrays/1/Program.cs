using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[x];
            //store elements in an array and print it
            for (int i = 0; i < x; i++)
            {
                if (i != 0)
                {
                    array[i] = i;
                }
            }

            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
        }
    }
}
