using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_new_arr_taking_the_elements_before_the_element_value_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] item = NewArr(new[] { 1, 2, 3, 5, 7 });
        }

        //create a new array taking the elements before the element value 5 from a given array of integers
        static int[] NewArr(int[] nums)
        {
            List<int> newArray = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 5)
                {
                    newArray.Add(nums[i]);
                }
                else
                {
                    break;
                }
                
            }
            foreach (int item in newArray)
            {
                Console.WriteLine(item);
            }
            return newArray.ToArray();
        }

        //Another Example
        static int[] test(int[] numbers)
        {
            int size = 0;
            int[] pre_ele_5;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 5)
                {
                    size = i;
                    break;
                }
            }
            pre_ele_5 = new int[size];

            for (int j = 0; j < size; j++)
            {
                pre_ele_5[j] = numbers[j];
            }
            return pre_ele_5;
        }
    }
}
