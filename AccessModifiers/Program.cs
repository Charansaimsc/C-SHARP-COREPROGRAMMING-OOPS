using System;
namespace AcessModifiers
{
    public class Program
    {
        static void Main(string[] args)
        {

            //// Base class object
            //Student s1 = new Student(101, "Charan", 8.5);
            //s1.DisplayStudent();

            //Console.WriteLine();

            //// Modify CGPA using public method
            //s1.SetCGPA(9.1);
            //Console.WriteLine("Updated CGPA: " + s1.GetCGPA());

            //Console.WriteLine();

            //// Derived class object
            //PostgraduateStudent pg = new PostgraduateStudent(201, "Sai", 8.9, "Artificial Intelligence");
            //pg.DisplayPostgraduateDetails();


            //    Book e = new EBook(
            //    "978-0132350884",
            //    "Clean Code",
            //    "Robert C. Martin",
            //    "PDF"
            //);

            //    ((EBook)e).DisplayEBookDetails();

            //    // Accessing public member
            //    Console.WriteLine("ISBN from Main: " + e.ISBN);


            //Manager  e1 = new Manager(101, "cse", 1000, "good");
            //e1.SetSalary(100444);
            //e1.Display();


            BankAccount b1 = new BankAccount(12345, 10000, "sai");
            b1.setBalance(10022);
            Console.WriteLine(b1.getBalance());
        }
    }
}