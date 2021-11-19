using System;

namespace Exercise7
{
    public class ATMtransaction
    {
        private int balance;

        public ATMtransaction()
        {
            balance = 1000;
        }

        public ATMtransaction(int val)
        {
            balance = val;
        }

        public void BalanceCheck()
        {
            Console.WriteLine($"The Balance of This Account is {balance}");
        }

        public int CashWithdrawal(int value)
        {
            if (balance < value)
            {   Console.WriteLine("Sorry, there is no enough money in your account");
                return -1;
            }
            Console.WriteLine("Withdraw cash successfully!");
            balance -= value;
            return 1;
        }

        public void CashDeposition(int value)
        {
            balance += value;
            Console.WriteLine("{value} dollors has been deposited in your account");
        }
        
    }
}