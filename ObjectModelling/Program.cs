using System;
namespace Objectss
{
    public class Progran
    {
        static void Main(string[] args)
        {
            //
            // Bank bank =new Bank("sbi");
            //    Customer c1 = new Customer("sai");
            //    Customer c2 = new Customer("charan");
            //    bank.OpenAccount(c1, 101, 100);
            //    bank.OpenAccount(c2, 102, 1000);
            //    c1.ViewBalance();
            //    c1.ViewBalance();
            //



            Book b1 = new Book("c#", "sai");
            Book b2 = new Book("csharp", "charan");
            Book b3 = new Book("programing", "sais");
            Library lib1 = new Library("Central Library");
            Library lib2 = new Library("Community Library");

            lib1.AddBook(b1);
            lib1.AddBook(b2);
            lib2.AddBook(b3);


            lib1.Display();
            lib2.Display();

        }
    }
}