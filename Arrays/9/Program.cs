using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                int num;
                Console.Write("Enter a number at index {0} : ",i);
                num = Convert.ToInt32(Console.ReadLine());
                arr[i] = num;
            }

            Console.WriteLine("The maximum element in the array is {0}", arr.Max());
            Console.WriteLine("The minimum element in the array is {0}", arr.Min());
        }

        //find maximum and minimum element in an array
    }
}
