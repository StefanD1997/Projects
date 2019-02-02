using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_new_list_from_a_list_of_ints_removing_values_with_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = CreateList(new List<int>(new int[] { 10, 22, 35, 47, 53, 67 }));
            foreach (int item in mylist)
            {
                Console.WriteLine(item);
            }
        }

        //create a new list from a given list of integers removing those values end with 7
        static List<int> CreateList(List<int> nums)
        {
            List<int> newList = new List<int>();
            foreach (int item in nums)
            {
                if (item % 10 != 7)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        //Another Example
        public static List<int> test(List<int> nums)
        {
            return nums.Where(n => n % 10 < 7).ToList();
        }
    }
}
