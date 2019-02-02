using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_arr_contain_the_middle_elements_from_given_arr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 10, 20, 30, 40, 50, 60, 80 };
            int[] z = { 10, 20, -30, -40, 50, 60, 80, 100 };
            CreateNewArray(x, z);
            
        }

        //create a new array containing the middle elements from the two given arrays of integers, each length 5
        static int[] CreateNewArray(int[] nums, int[] nums2)
        {
            int[] newArr = { };
            int firstArr = nums[nums.Length / 2];
            int secondArr = nums2[nums2.Length / 2];
            List<int> Arr = new List<int>();
            Arr.Add(firstArr);
            Arr.Add(secondArr);
            Arr.ToArray();
            newArr = Arr.ToArray();
            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }
            return newArr;
        }
    }
}
