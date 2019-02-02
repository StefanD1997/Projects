using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_list_ints_where_each_int_is_multiplied_itself_3times
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> mylist = NewList(new List<double>(new double[] { 1, 2, 3, 4 }));
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
        }

        //create a new list from a given list of integers where each integer multiplied by itself three times
        static List<double> NewList(List<double> nums)
        {
            IEnumerable<double> newValues = nums.Select(x => x * x * x);
            return newValues.ToList();
        }
    }
}
