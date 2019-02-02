using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_the_elements_of_a_given_array_of_integers__length_4__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RotateArray(new[] { 10, 20, -30, -40 }));
        }

        //rotate the elements of a given array of integers (length 4 ) in left direction and return the new array.
        static int[] RotateArray(int[] nums)
        {
            int[] retVal = nums.Skip(1).ToArray();
            Array.Resize(ref retVal, nums.Length);
            retVal[nums.Length - 1] = nums[0];
            foreach (var item in retVal)
            {
                Console.WriteLine(item);
            }
            return retVal;
        }
    }
}
