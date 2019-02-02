using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_list_of_the_rightmost_digits_from_a_list_of_integers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = CreateList(new List<int>(new int[] { 10, 22, 35, 41 }));
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
        }

        //create a new list of the rightmost digits from a given list of positive integers
        static List<int> CreateList(List<int> nums)
        {
            return nums.Select(x => x % 10).ToList();
        }
    }
}
