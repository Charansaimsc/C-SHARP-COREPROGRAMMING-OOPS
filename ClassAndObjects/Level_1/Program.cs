using System;
namespace Level_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //EmployeeDetails emp = new EmployeeDetails("charan", 101, 10000);
            //emp.DisplayDetails();

            //Circle obj = new Circle(10);
            //obj.Display();

            HandleBookDetails obj = new HandleBookDetails("Wings","charan",100);
            obj.Display();
        }
    }
}