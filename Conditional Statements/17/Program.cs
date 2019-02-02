using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            int cprice, sprice;
            Console.Write("Enter  price : ");
            cprice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter sell price : ");
            sprice = Convert.ToInt32(Console.ReadLine());
            CalcProfitOrLoss(cprice, sprice);
        }

        //calculate profit and loss on a transaction
        static void CalcProfitOrLoss(int cprice, int sprice)
        {
            int plmat;
            if (sprice > cprice)
            {
                plmat = sprice - cprice;
                Console.WriteLine("Your amount  after purchase : {0}", plmat);
            }
            else if (cprice > sprice)
            {
                plmat = cprice - sprice;
                Console.WriteLine("Your cannot purchase because you trasaction would be : -{0}", plmat);
            }
            else
            {
                Console.WriteLine("No loss and no profit");
            }
        }
    }
}
