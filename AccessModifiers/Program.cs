using System;
namespace AcessModifiers
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Base class object
            Student s1 = new Student(101, "Charan", 8.5);
            s1.DisplayStudent();

            Console.WriteLine();

            // Modify CGPA using public method
            s1.SetCGPA(9.1);
            Console.WriteLine("Updated CGPA: " + s1.GetCGPA());

            Console.WriteLine();

            // Derived class object
            PostgraduateStudent pg = new PostgraduateStudent(201, "Sai", 8.9, "Artificial Intelligence");
            pg.DisplayPostgraduateDetails();
        }
    }
}