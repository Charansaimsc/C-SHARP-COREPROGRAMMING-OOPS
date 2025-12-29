/*Create a BankAccount class with the following features:
● static:
o A static variable bankName shared across all accounts.
o A static method GetTotalAccounts() to display the total number of accounts.
● this:
o Use this to resolve ambiguity in the constructor when initializing
AccountHolderName and AccountNumber.

● readonly:
o Use a readonly variable AccountNumber to ensure it cannot be changed once
assigned.
● is operator:
o Check if an account object is an instance of the BankAccount class before
displaying its details.*/



using System;

class BankAccount
{
 
    public static string BankName = "State Bank of India";
    private static int totalAccounts = 0;

    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts Created: " + totalAccounts);
    }

   
    public string AccountHolderName;
    public readonly int AccountNumber;  
    public double Balance;

   
    public BankAccount(string accountHolderName, int accountNumber, double balance)
    {
        this.AccountHolderName = accountHolderName;
        this.AccountNumber = accountNumber; 
        this.Balance = balance;

        totalAccounts++; 
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Bank Name       : " + BankName);
        Console.WriteLine("Account Holder  : " + AccountHolderName);
        Console.WriteLine("Account Number  : " + AccountNumber);
        Console.WriteLine("Balance         : " + Balance);
        Console.WriteLine("--------------------------------");
    }
}