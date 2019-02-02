using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_arr_swap_the_first_last_elements_of_a_given_arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 10, 20, 30, 40, 50, 60 };
            Console.WriteLine(CreateNewArr(x)); 
        }

        //create a new array swapping the first and last elements of a given array of integers and length will be least 1
        static int[] CreateNewArr(int[] nums)
        {
            int firstNum = nums[0];
            int lastNum = nums[nums.Length - 1];
            nums[0] = lastNum;
            nums[nums.Length - 1] = firstNum;
            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }
            return nums;
        }

        //Another Example
        static int[] test(int[] numbers)
        {
            int first = numbers[0];
            numbers[0] = numbers[numbers.Length - 1];
            numbers[numbers.Length - 1] = first;

            return numbers;
        }
    }
}
