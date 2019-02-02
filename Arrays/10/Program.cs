using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int[] evenArr = new int[n];
            int[] oddArr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                int num;
                Console.Write("Enter a number at index {0} : ",i);
                num = Convert.ToInt32(Console.ReadLine());
                arr[i] = num;
            }
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArr[i] = arr[i];
                }
                else if (arr[i] % 2 != 0)
                {
                    oddArr[i] = arr[i];
                }
            }

            Console.WriteLine("Even numbers are : ");
            foreach (int item in evenArr)
            {
                if (item != 0)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Odd numbers are : ");
            foreach (int item in oddArr)
            {
                if (item != 0)
                {
                    Console.Write(item + " ");
                }
            }
        }

        //separate odd and even integers in separate arrays
    }
}
