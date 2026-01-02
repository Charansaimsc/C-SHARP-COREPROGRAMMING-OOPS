using System;

public class BankAccount
{
    public string AccountNumber { get; }
    public double Balance { get; protected set; }

    public BankAccount(string accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public virtual void DisplayAccountType()
    {
        Console.WriteLine("Generic Bank Account");
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Account Number : {AccountNumber}");
        Console.WriteLine($"Balance        : ₹{Balance}");
    }
}
public class SavingsAccount : BankAccount
{
    public double InterestRate { get; }

    public SavingsAccount(string accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        InterestRate = interestRate;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Account Type   : Savings Account");
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Interest Rate : {InterestRate}%");
    }
}
public class CheckingAccount : BankAccount
{
    public double WithdrawalLimit { get; }

    public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance)
    {
        WithdrawalLimit = withdrawalLimit;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Account Type   : Checking Account");
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Withdrawal Limit : ₹{WithdrawalLimit}");
    }
}
public class FixedDepositAccount : BankAccount
{
    public int LockInPeriod { get; } // in months

    public FixedDepositAccount(string accountNumber, double balance, int lockInPeriod)
        : base(accountNumber, balance)
    {
        LockInPeriod = lockInPeriod;
    }

    public override void DisplayAccountType()
    {
        Console.WriteLine("Account Type   : Fixed Deposit Account");
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Lock-in Period : {LockInPeriod} months");
    }
}
