
/*Bank Account Management
● Create a BankAccount class with:
o accountNumber (public)
o accountHolder (protected)
o balance (private)
● Implement methods to:
o Access and modify balance using public methods.
o Create a subclass SavingsAccount to demonstrate access to accountNumber
and accountHolder.*/


using System;

public class BankAccount
{
	public int accountNumber { get; set; }
	
	protected string accountHolder{get ; set;}
    private double balance { get; set; }
    public BankAccount(int accountNumber,double balance,string accountHolder)
	{
		this.accountHolder = accountHolder;
		this.balance = balance;
		this.accountNumber = accountNumber;
	}

	public double getBalance()
	{
		return balance;
	}
	public void setBalance(double newbalance)
	{
		balance = newbalance;

	}

	public class SavingAccount : BankAccount
	{
		public SavingAccount(int accountNumber,string accountHolder,double balance) : base(accountNumber, balance, accountHolder)
		{

		}
		public void Display()
		{
			Console.WriteLine("accountNumber : " + accountNumber);
            Console.WriteLine("accountHolderName" + accountHolder);
			Console.WriteLine("accountBalance ;" + getBalance());

        }
    }
}
