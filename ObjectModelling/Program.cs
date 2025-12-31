using System;
using System.Reflection;
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



            //Book b1 = new Book("c#", "sai");
            //Book b2 = new Book("csharp", "charan");
            //Book b3 = new Book("programing", "sais");
            //Library lib1 = new Library("Central Library");
            //Library lib2 = new Library("Community Library");

            //lib1.AddBook(b1);
            //lib1.AddBook(b2);
            //lib2.AddBook(b3);


            //lib1.Display();
            //lib2.Display();


            //  Company c1 = new Company("Acess meditech");
            //  Company c2 = new Company("Access meditech");

            //  Company c3 = new Company("Acessss meditech");

            //  c1.AddDepartment("Engineering");
            // c1.Departments[0].AddEmployee("Alice");
            //c1.Departments[0].AddEmployee("Bob");

            //  Console.WriteLine("Company:"+c1.CompanyName);
            //  Console.WriteLine($"Department: {c1.Departments[0].DepartmentName}");

            //  c1 = null;

            //  Console.WriteLine("Company deleted. Child objects are now unreachable.");


                School school = new School("ABC School");

                Student s1 = new Student(101);
                Student s2 = new Student(102);

                Course c1 = new Course("Math");
                Course c2 = new Course("Science");

                school.AddStudent(s1);
                school.AddStudent(s2);

                s1.EnrollCourse(c1);
                s1.EnrollCourse(c2);
                s2.EnrollCourse(c1);

                s1.ShowCourses();
                Console.WriteLine();
                c1.ShowStudents();
            
        

        }
    }
}