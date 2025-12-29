using System;

public class Employee
{
    public int EmployeeID;
    protected string Department;
    private int Salary;

    public Employee(int employeeID, string department, int salary)
    {
        EmployeeID = employeeID;
        Department = department;
        Salary = salary;
    }

    public int GetSalary()
    {
        return Salary;
    }

    public void SetSalary(int newSalary)
    {
        Salary = newSalary;
    }
}

public class Manager : Employee
{
    public string Nature;

    public Manager(int employeeID, string department, int salary, string nature)
        : base(employeeID, department, salary)
    {
        Nature = nature;
    }

    public void Display()
    {
        Console.WriteLine(
            "Employee ID: " + EmployeeID +
            "\nDepartment: " + Department +
            "\nSalary: " + GetSalary() +
            "\nNature: " + Nature
        );
    }
}

