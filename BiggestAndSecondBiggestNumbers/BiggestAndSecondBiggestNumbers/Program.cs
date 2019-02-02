using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestAndSecondBiggestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            BiggestAndSecondBiggest(5, arr);
        }

        static int[] BiggestAndSecondBiggest(int N, int[] numbers)
        {
            N = numbers.Length;
            int i = 0, j = 0, largest, secondlargest;

            largest = 0;
            for ( i = 0; i < N; i++)
            {
                if (largest < numbers[i])
                {
                    largest = numbers[i];
                    j = i;
                }
            }

            secondlargest = 0;
            for (i = 0; i < N; i++)
            {
                if (i == j)
                {
                    i++;
                    i--;
                }
                else
                {
                    if (secondlargest < numbers[i])
                    {
                        secondlargest = numbers[i];
                    }
                }
            }

            int[] nums = { largest, secondlargest };
            Console.Write("Largest num {0} and Second largest {1}\n", largest, secondlargest);
            return nums;

        }
    }
}
