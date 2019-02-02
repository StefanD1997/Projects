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
            int n;
            
            Console.Write("Enter how much elements can one array have : ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            int[] arr1 = new int[n];
            int[] newArr = new int[arr.Length + arr1.Length];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a number at index [{0}] : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {
                Console.Write("Enter a number at index [{0}] : ", j);
                arr1[j] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (int item in arr1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Merging Arrays");
            Array.Copy(arr, newArr, arr.Length);
            Array.Copy(arr1, 0, newArr, arr.Length, arr1.Length);
            Console.WriteLine();
            foreach (int item in newArr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Sorting Array");
            Array.Sort(newArr);
            Console.WriteLine();
            foreach (int item in newArr)
            {
                Console.WriteLine(item);
            }
        }

        //merge two arrays of same size sorted in ascending order
    }
}
