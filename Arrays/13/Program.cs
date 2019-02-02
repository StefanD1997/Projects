using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter the number of integers the array can contain : ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                int num;
                Console.Write("Enter a number at index {0} : ", i);
                num = Convert.ToInt32(Console.ReadLine());
                arr[i] = num;
            }
            Console.WriteLine();
            Console.Write("Numbers in array : ");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            int s;
            Console.WriteLine("Enter a number which indicates how much numbers you want to add to that array : ");
            s = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref arr, arr.Length + s);
            for (int i = arr.Length - s; i < arr.Length; i++)
            {
                int newNum;
                Console.Write("Add a number to array at index {0} : ", i);
                newNum = Convert.ToInt32(Console.ReadLine());
                arr[i] = newNum;
            }
            Console.WriteLine("Sorted Array");
            Array.Sort(arr);
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }

        }

        //insert New value in the array (sorted list )
    }
}
