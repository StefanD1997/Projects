using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter a number : ");
            x = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[x];
            //read n number of values in an array and display it in reverse order
            for (int i = 0; i < x; i++)
            {
                array[i] = i;
            }
            Console.WriteLine("Before Reverse");
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After Reverse");
            ReverseArray(array);
        }

        static void ReverseArray(int[] arr)
        {
            Array.Reverse(arr);
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }
        }
    }
}
