using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_List_from_a_list_of_ints_where_each_int
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = CreateList(new List<int>(new int[] { 1, 2, 3, 4 }));
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
        }

        //create a new list from a given list of integers where each integer value is added to 2 and the result
        //value is multiplied by 5
        static List<int> CreateList(List<int> nums)
        {
            return nums.Select(x => (x + 2) * 5).ToList();
        }
    }
}
