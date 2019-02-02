using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, ctr = 0;
            int[] arr1 = new int[100];
            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (int s = 0; s < n; s++)
            {
                Console.Write("element - {0} : ", s);
                arr1[s] = Convert.ToInt32(Console.ReadLine());
            }
            //print all unique elements in an array

            for (int i = 0; i < n; i++)
            {
                ctr = 0;

                for (int j = 0; j < i - 1; j++)
                {
                    if (arr1[i] ==  arr1[j])
                    {
                        ctr++;
                    }
                }

                for (int k = i + 1; k < n; k++)
                {
                    if (arr1[i] == arr1[k])
                    {
                        ctr++;
                    }
                }

                if (ctr == 0)
                {
                    Console.Write("{0} ", arr1[i]);
                }
            }
            Console.Write("\n\n");
        }
    }
}
