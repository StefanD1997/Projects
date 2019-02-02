using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_list_from_a_list_of_integers_removing_ints_smaller_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = CreateList(new List<int>(new int[] { 0, -2, 1, 2, 3, 5, 4, 7, 8 }));
            foreach (int item in mylist)
            {
                Console.WriteLine(item);
            }
        }

        //create a new list from a given list of integers removing those values which are less than 4
        static List<int> CreateList(List<int> nums)
        {
            nums.RemoveAll(x => x >= 4);
            return nums;
        }

        //Another Example
        public static List<int> test(List<int> nums)
        {
            return nums.Where(n => n < 4).ToList();
        }
    }
}
