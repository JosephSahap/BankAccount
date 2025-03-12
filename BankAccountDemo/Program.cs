// See https://aka.ms/new-console-templare for more information
using BankAccount;

BankAccount.BankAccount ba = new BankAccount.BankAccount("Joseph", 100);
ba.deposit(40);
Console.WriteLine(ba.AccountHolder + "has a balance of " + ba.Balance);