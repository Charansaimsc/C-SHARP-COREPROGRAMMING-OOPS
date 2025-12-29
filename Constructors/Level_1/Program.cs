using System;
using System.Net.Http.Headers;
namespace Level_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Book obj = new Book();
            //obj.Display();
            //Book obj2 = new Book("alice", "asdf", 199);
            //obj2.Display();


            //    Circle c1 = new Circle();
            //    c1.Display();
            //    Circle c2 = new Circle(100);
            //    c2.Display();


       
                
                Book book1 = new Book("C# Programming", "Charan", 499.99);

                // Display details
                book1.DisplayDetails();

                // Borrow the book
                book1.BorrowBook();

                // Try borrowing again
                book1.BorrowBook();
         
        

        }
    }
}