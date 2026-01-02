using System;
namespace ooppillar
{

    public class Program
{
    static void Main(string[] args)
    {

        List<Employee> employees = new List<Employee>();
        Employee emp1 = new FullTimeEmployee(101, "Charan", 500, 20);
        emp1.AssignDepartment("IT");
        Employee emp2 = new PartTimeEmployee(102, "Sai", 15000);
        emp2.AssignDepartment("HR");
        employees.Add(emp1);
        employees.Add(emp2);
        foreach (Employee emp in employees)
        {
            emp.DisplayDetails();
        }

    }
}
}