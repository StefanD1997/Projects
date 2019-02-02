using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[x];
            int[] copyArr = new int[x];
            //copy the elements one array into another array 
            for (int i = 0; i < x; i++)
            {
                arr[i] = i;
            }
            Print(arr);
            Array.Copy(arr, copyArr, arr.Length);
            Console.WriteLine("Copied Array");
            Print(copyArr);
            
        }

        static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
