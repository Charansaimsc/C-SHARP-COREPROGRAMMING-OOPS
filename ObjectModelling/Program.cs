using System;
namespace Objectss
{
    public class Progran
    {
        static void Main(string[] args)
        {
            Bank bank =new Bank("sbi");
            Customer c1 = new Customer("sai");
            Customer c2 = new Customer("charan");
            bank.OpenAccount(c1, 101, 100);
            bank.OpenAccount(c2, 102, 1000);
            c1.ViewBalance();
            c1.ViewBalance();
        }
    }
}