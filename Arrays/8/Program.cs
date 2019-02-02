using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 1, 2, 3, 4, 5, 6, 5, 7, 8, 7, 4, };
            int[] newArr = { 1, 2, 1, 2, 3, 4, 5, 6, 5, 7, 8, 7, 4, };


            int currNum, cnt = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                currNum = arr[i];
                cnt = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (currNum == arr[j])
                    {
                        cnt++;
                        newArr[j] = 0;
                    }
                }

                if (newArr[i] != 0)
                {
                    newArr[i] = cnt;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (newArr[i] != 0)
                {
                    Console.WriteLine("{0} = {1}", arr[i], newArr[i]);
                }
            }
        }

        //count the frequency of each element of an array
    }
}
