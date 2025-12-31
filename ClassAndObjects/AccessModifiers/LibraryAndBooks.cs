/*Description: Model a relationship where a Bank has Customer objects associated with it. A
Customer can have multiple bank accounts, and each account is linked to a Bank.
Tasks:
● Define a Bank class and a Customer class.
● Use an association relationship to show that each Customer has an account in a
Bank.
● Implement methods that enable communication, such as OpenAccount() in the Bank
class and ViewBalance() in the Customer class.
Goal: Illustrate association by setting up a relationship between customers and the bank.*/

using System;

public class Bank
{
	public string BankName { get; set; }
	public Bank(string bankName)
	{
		BankName = bankName; 
	}

	public void OpenBankAccount(string name,)
	{

	}
	{
	}
}
