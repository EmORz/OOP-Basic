using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class BankAccount
    {
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
        public void WithDraw(decimal amount)
        {
            this.Balance -= amount;
        }
        public override string ToString()
        {
            return $"Account ID{ID}, balance {Balance:f2}";
        }
        
    }
}
