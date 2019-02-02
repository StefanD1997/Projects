using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 8, 1, 3, 9, 10, 4, 6, 4 };
            Array.Sort(arr);
            Console.WriteLine("Ascending order");
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Descending order");
            foreach (int item in arr.OrderByDescending(x => x))
            {
                Console.WriteLine(item);
            }
        }

        //sort elements of array in ascending order

    }
}
