using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime;

public class BankAccount
{
    public string AccNumber {get; private set;}
    public double Balance {get; private set;}
    public string OwnerName {get; set;}

/*    public void SetAccNum(string newNum)
    {
        if(!string.IsNullOrEmpty(newNum))
        {
            AccNumber = newNum;
        }
        else
        {
            Console.WriteLine("Account number cannot be empty.");
        }
    }

    public void SetBalance(double newBalance)
    {
        if(newBalance > 0)
        {
            Balance = newBalance;
        }
        else if(newBalance == 0)
        {
            Console.WriteLine("There is no money left on your account.");
        }
        else
        {
            Console.WriteLine("This bank account cannot be in the negative.");
        }
    }
*/
    public void Deposit(double amount)
    {
        if(amount >= 0)
        {
            Balance = Balance + amount;
            Console.WriteLine($"Deposited {amount}$. New Balance: {Balance + amount}$");        
        }
        else
        {
            throw new Exception("Amount deposited must be above zero.");
        }
    }

    public void Withdraw(double amount)
    {
        if(amount >= 0)
        {
            Balance = Balance - amount;
            Console.WriteLine($"Withdrew {amount}$. New Balance: {Balance - amount}$");
        }
        else
        {
            throw new Exception("Amount withdrawn must be above zero.");
        }
    }

    public void DisplayInfo()
    {
        Console.Write($"Account Number: {AccNumber}\nOwner Name: {OwnerName}\nBalance: {Balance:0.00}$\n");
    }

    public BankAccount(string name, string accNum, double initialBalance)
    {
        Balance = initialBalance;
        OwnerName = name;
        AccNumber = accNum;
    }
}

class Program
{
    static void Main()
    {
        BankAccount bankA = new BankAccount("John Doe", "0001", 10000);
        bankA.DisplayInfo();
        bankA.Deposit(1000);
        Console.WriteLine(bankA.Balance);
        bankA.Withdraw(2000);
        Console.WriteLine(bankA.Balance);
    }
}