using System;
namespace keywords
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount("Charan", 101, 50000);
            BankAccount acc2 = new BankAccount("Sai", 102, 75000);


            if (acc1 is BankAccount)
            {
                acc1.DisplayDetails();
            }

            if (acc2 is BankAccount)
            {
                acc2.DisplayDetails();
            }

            BankAccount.GetTotalAccounts();

        }  
    }
}