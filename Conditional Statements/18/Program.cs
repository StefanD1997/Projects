using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            int id, units;
            string name;

            Console.Write("Enter Customer ID : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Customer Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Customer ID : ");
            units = Convert.ToInt32(Console.ReadLine());
            CalcElectricityBill(id, name, units);
        }

        // calculate and print the Electricity bill of a given customer. The customer id., name and unit consumed by the user should be taken from the keyboard and display the total amount to pay to the customer
        static void CalcElectricityBill(int id, string name, int unitsConsumed)
        {
            double crg, surcharge = 0, grmat, netmat =0;

            if (unitsConsumed <= 199)
            {
                crg = 1.20;
            }
            else if (unitsConsumed <= 400)
            {
                crg = 1.50;
            }
            else if (unitsConsumed <= 600)
            {
                crg = 1.80;
            }
            else
            {
                crg = 2.0;
            }

            grmat = unitsConsumed * crg;

            if (grmat > 300)
            {
                surcharge = grmat * 15 / 100.0;
                netmat = grmat + surcharge;
            }
            if (netmat <= 100)
            {
                netmat = 100;
            }

            Console.WriteLine("Electricity Bill");
            Console.WriteLine("Customer ID : {0}", id);
            Console.WriteLine("Customer Name : {0}", name);
            Console.WriteLine("Units Consumed : {0}", unitsConsumed);
            Console.WriteLine("Amount Charges @Rs. : {0} per unit :{1}", crg, grmat);
            Console.WriteLine("Surcharge Amount : {0}", surcharge);
            Console.WriteLine("Net Amount Paid by customer : {0}", netmat);
        }
    }
}
