using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    { }
}

public class BankAccount
{
    private decimal balance;

    public decimal getBalance
    {
        get {  return balance; } 
    }
    public void deposit (int n)
    {
        balance += n; 
    }
    public void withdraw (int n)
    {
        if (balance>n)
        {
            balance -= n;
        }
    }
}
