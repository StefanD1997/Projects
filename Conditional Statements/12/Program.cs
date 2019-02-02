using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int rollNo, mark, cnt = 0;
            string name, nameSub;
            List<KeyValuePair<string, int>> marks = new List<KeyValuePair<string, int>>();

            Console.Write("Enter Roll No : ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            do
            {
                Console.Write("Enter Name of Subject : ");
                nameSub = Console.ReadLine();
                Console.Write("Enter Marks of Subject : ");
                mark = Convert.ToInt32(Console.ReadLine());
                marks.Add(new KeyValuePair<string, int>(nameSub, mark));
                cnt++;
            } while (cnt != 3);
            Console.WriteLine();
            Calc(rollNo, name, marks);

        }

        //read roll no, name and marks of three subjects and calculate the total, percentage and division
        static void Calc(int x, string name, List<KeyValuePair<string, int>> marks)
        {
            int result = 0;
            int totalMarks = 300;
            Console.WriteLine("Roll No : {0}", x);
            Console.WriteLine("Name of Student : {0}", name);
            foreach (var item in marks)
            {
                string sub = item.Key;
                int mark = item.Value;
                Console.WriteLine("Marks in {0} : {1}", sub, mark);
            }
            foreach (var item in marks)
            {
                int n = item.Value;
                result += n;
            }
            Console.WriteLine("Total marks = {0}", result);
            double p = Precentage(result, totalMarks);
            Console.WriteLine("Precentage : {0}", p);
            if (p >= 80)
            {
                Console.WriteLine("Division = First");
            }
            else if (p >= 50)
            {
                Console.WriteLine("Division = Second");
            }
            else
            {
                Console.WriteLine("Divison = Third");
            }


        }

        static double Precentage(double n, double m)
        {
            double precentage;
            //First divide low number by high: 7/300 = 0.023 Second: multiply result by 100. 0.023*100 = 2.33% Answer: 2.33%
            precentage = (n / m) * 100;
            return precentage;
        }
    }
}
