using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[x];
            //find the sum of all elements of the array 
            for (int i = 0; i < x; i++)
            {
                arr[i] = i;
            }
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sum of all elements in array is {0}", arr.Sum());
        }
    }
}
