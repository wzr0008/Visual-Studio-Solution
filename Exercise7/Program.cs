using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Exercise7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Pin Number");
            string pin = Console.ReadLine();
            ATMtransaction atMtransaction = new ATMtransaction();
            while (true)
            {
                Console.WriteLine("**************Welcome To ATM Service********************");
                Console.WriteLine("1.Check Balance");
                Console.WriteLine("2.Withdraw Cash");
                Console.WriteLine("3.Deposit Cash");
                Console.WriteLine("4.Quit");
                Console.WriteLine("********************************************************");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        atMtransaction.BalanceCheck();
                        break;
                    case 2:
                        Console.WriteLine("Please Input the amount of money you want to withdraw");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        atMtransaction.CashWithdrawal(amount);
                        break;
                    case 3:
                        Console.WriteLine("Please Input the amount of money you want to deposit");
                        int depos = Convert.ToInt32(Console.ReadLine());
                        atMtransaction.CashDeposition(depos);
                        break;
                    case 4:
                        break;
                }
                
            }
        }
        
    }
}