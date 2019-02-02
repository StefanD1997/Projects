using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_a_list_from_a_list_of_str_where_each_elem_is_copied_x4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = CreateList(new List<string>(new string[] { "1", "2", "3", "4" }));
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            
        }

        //create a new list from a given list of strings where each element is replaced by 4 copies of the
        //string concatenated together
        static List<string> CreateList(List<string> str)
        {
            var s = str.Select(x => x.Replace(x, x + x + x + x));
            return s.ToList();
        }
    }
}
