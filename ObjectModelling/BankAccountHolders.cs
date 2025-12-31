using System;

public class Account

{
	public int accountNumber { get; set; }
	public double Balance { get; set; }
	public Bank Bank { get; set; }

	public Account(int accountNumber,double Balance,Bank bank)

	{
		this.accountNumber = accountNumber;
		this.Balance = Balance;
		this.Bank = bank;
	}
}
public class Customer
{
	public string customerName { get; set; }
	public List<Account> Accounts;
	public Customer(string name)
	{
		this.customerName = name;
		Accounts = new List<Account>();
	}
	public void		ViewBalance()
	{
		for (int i = 0; i < Accounts.Count; i++)
		{
			Account acc = Accounts[i];
			Console.WriteLine(acc.accountNumber + "\n" + acc.Balance + "\n" + acc.Bank.BankName);
		}
	}
}

public class Bank 
{
	public string BankName {  get; set; }
	public Bank(string BankName)
	{
		this.BankName = BankName;

	}
	public void OpenAccount(Customer customer, int accountNumber, int initialBalance)
	{
		Account acc = new Account(accountNumber, initialBalance, this);
		customer.Accounts.Add(acc);


		Console.WriteLine("new account created " + BankName + "details" + accountNumber + "\n" + initialBalance);
	}
}

