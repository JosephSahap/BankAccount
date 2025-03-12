using System;
using System.Collections.Generic;


namespace BankAccount {
    public class BankAccount
    {
        private string accountHolder;
        private decimal balance;

        public BankAccount(string accountHolder, decimal initialBalance)
        {
            this.accountHolder = accountHolder;
            this.balance = initialBalance;
        }
        public void deposit(decimal amount)
        {
            this.balance += amount;
        }
        public void withdraw(decimal amount)
        {
            this.balance -= amount;
        }
        public decimal Balance { get { return this.balance; } }
        public string AccountHolder { get { return this.accountHolder; } }
    }
}







/*namespace BankAccountDemo
{
    public class BankAccount
    {
        public string Owner { get; }
        public decimal Balance { get; private set; }
        private List<decimal> transactions = new List<decimal>();

        public BankAccount(string owner, decimal initialBalance)
        {
            Owner = owner;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0) throw new ArgumentException();
            Balance += amount;
            transactions.Add(amount);
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > Balance) throw new ArgumentException();
            Balance -= amount;
            transactions.Add(-amount);
        }
    }
}*/





