using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, password;
            int ctr = 0, dd = 0;

            Console.WriteLine("Username = username, Password = password");
            Console.WriteLine("----------------------------------------");

            do
            {
                Console.Write("Enter username : ");
                username = Console.ReadLine();

                Console.Write("Enter password : ");
                password = Console.ReadLine();

                if (username == "username" && password == "password")
                {
                    dd = 1;
                    ctr = 3;
                }
                else
                {
                    dd = 0;
                    ctr++;
                }
            }
            while ((username != "username" || password != "password") && (ctr != 3));
            if (dd == 0)
            {
                Console.WriteLine("Login attempt more than three times. Try again later");
            }
            else
            {
                if (dd == 1)
                {
                    Console.WriteLine("Logged In");
                }
            }
        }

        //that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected
    }
}
