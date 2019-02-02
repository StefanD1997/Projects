using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write("Enter marks for mathematics : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks for physics : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter marks for chemistry : ");
            z = Convert.ToInt32(Console.ReadLine());
            Admission(x, y, z);
        }

        // find the eligibility of admission for a professional course based on the following criteria
        static void Admission(int math, int phy, int chem)
        {
            const int Mathematics = 65;
            const int Physics = 55;
            const int Chemistry = 50;
            int total = Mathematics + Physics + Chemistry;
            int studentTotal = math + phy + chem;

            if (studentTotal >= total)
            {
                Console.WriteLine("The candidate is eligible for admission");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission");
            }
        }
    }
}
