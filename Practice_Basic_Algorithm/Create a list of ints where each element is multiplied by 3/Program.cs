using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_list_of_ints_where_each_element_is_multiplied_by_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = NewList(new List<int>(new int[] { 1, 2, 3, 4 }));
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
        }

        //create a new list from a given list of integers where each element is multiplied by 3
        static List<int> NewList(List<int> nums)
        {
            IEnumerable<int> newNums = nums.Select(x => x *= 3);
            return newNums.ToList();
        }
    }
}
