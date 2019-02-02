using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_new_arr_taking_the_elements_after_the_element_value_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 2, 3, 0, 7, 5, 11, 15 });
        }

        //create a new array taking the elements after the element value 5 from a given array of integers
        static int[] test(int[] numbers)
        {
            int len = numbers.Length, size = 0, i = len - 1;
            int[] post_ele_5;

            while (i >= 0 && numbers[i] != 5) i--;
            i++;

            size = len - i;
            post_ele_5 = new int[size];

            for (int j = 0; j < size; j++)
            {
                post_ele_5[j] = numbers[i + j];
            }

            return post_ele_5;
        }
    }
}
