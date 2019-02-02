using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 1 };
            int[] arr2 = { 1, 2, 1 };
            int dups = 0;
            //count a total number of duplicate elements in an array
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        dups++;
                    }
                }
            }
            Console.WriteLine("Duplicates in arr {0}", dups);
        }
    }
}
