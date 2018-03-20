using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.SubComponents
{
    internal class BankAccount
    {
        private double balance = 1000;

        public bool CashRequestWithLimit(double cashRequest)
        {
            if (cashRequest > balance)
            {
                Console.WriteLine("Error, you do not have enough funds");
                return false;
            }
            return true;
        }

        public double WithdrawCash(double cashWithdrawl)
        {
            balance -= cashWithdrawl;
            Console.WriteLine("Withdrawn {0:c}", cashWithdrawl);
            Console.WriteLine("Current balance {0:c}", balance);
            return cashWithdrawl;
        }
    }
}
