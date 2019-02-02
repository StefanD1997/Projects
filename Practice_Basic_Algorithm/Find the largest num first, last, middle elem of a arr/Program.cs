using System;

namespace Find_the_largest_num_first__last__middle_elem_of_a_arr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindLargestNumber(new[] { 1 }));
            Console.WriteLine(FindLargestNumber(new[] { 1, 2, 9 }));
            Console.WriteLine(FindLargestNumber(new[] { 1, 2, 9, 3, 3 }));
            Console.WriteLine(FindLargestNumber(new[] { 1, 2, 3, 4, 5, 6, 7 }));
            Console.WriteLine(FindLargestNumber(new[] { 1, 2, 2, 3, 7, 8, 9, 10, 6, 5, 4 }));
        }

        //find the largest value from first, last, and middle elements of a given array of integers of odd length (atleast 1)
        static int FindLargestNumber(int[] nums)
        {
            return Math.Max(Math.Max(nums[nums.Length / 2], nums[nums.Length - 1]), nums[0]);
        }

        //Another Example
        static int test(int[] numbers)
        {
            int first, middle_ele, last_ele, max_ele;

            first = numbers[0];
            middle_ele = numbers[numbers.Length / 2];
            last_ele = numbers[numbers.Length - 1];
            max_ele = first;

            if (middle_ele > max_ele)
            {
                max_ele = middle_ele;
            }

            if (last_ele > max_ele)
            {
                max_ele = last_ele;
            }

            return max_ele;
        }
    }
}
