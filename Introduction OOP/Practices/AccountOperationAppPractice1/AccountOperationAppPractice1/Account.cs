using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperationAppPractice1
{
    class Account
    {
        public string accNo;
        public string customerName;
        private decimal balance;
        
        public decimal Deposite(decimal amount)
        {
            return balance += amount;
        }
        public decimal Withdraw(decimal amount)
        {
            return balance -= amount;
        }
        public string GetReport()
        {
            return customerName + " your total balance is " + balance;
        }
    }
}
