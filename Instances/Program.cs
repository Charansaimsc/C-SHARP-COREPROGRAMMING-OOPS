using System;

namespace instances
{
    public class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("salt", 1000);

            Product p2 = new Product("sugar", 12200);

            p1.DisplayProductDetails();
            Product.DisplayTotalStudents();
        }
    }
}