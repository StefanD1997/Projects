using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_a_list_of_strs_where_each_element_has_a_hashtag
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist = NewList(new List<string>(new string[] { "1", "2", "3", "4" }));
            foreach (var item in mylist)
            {
                Console.WriteLine(item);
            }
        }

        //create a new list from a given list of strings where each element has "#" added at the beginning and end position
        static List<string> NewList(List<string> strings)
        {
            IEnumerable<string> newValues = strings.Select(x => "#" + x + "#");
            return newValues.ToList();
        }
    }
}
