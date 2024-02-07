using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet2que2
{
    internal class BankAccount
    {
        public int AccountNumber;
        public double Balance;

        public void deposit(double amount)
        {
            Balance = Balance + amount;
        }
    }
}
