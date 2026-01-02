using System;
using System.Collections.Generic;


public interface IDepartment
{
    void AssignDepartment(string departmentName);
    string GetDepartmentDetails();
}
public abstract class Employee : IDepartment
{
    protected int employeeId;
    private double baseSalary;
    private string department;
    public int EmployeeId
    {
        get { return employeeId; }
    }

    public string Name { get; set; }

    protected double BaseSalary
    {
        get { return baseSalary; }
        set { baseSalary = value; }
    }

    public Employee(int employeeId, string name, double baseSalary)
    {
        this.employeeId = employeeId;
        this.Name = name;
        this.baseSalary = baseSalary;
    }

    public abstract double CalculateSalary();
    public void DisplayDetails()
    {
        Console.WriteLine( $"ID: {EmployeeId}, Name: {Name}, Salary: {CalculateSalary()}, Department: {department}");
    }
    public void AssignDepartment(string departmentName)
    {
        department = departmentName;
    }

    public string GetDepartmentDetails()
    {
        return department;
    }
}
public class FullTimeEmployee : Employee
{
    private int workingHours;
    private double hourlyRate;

    public FullTimeEmployee(int employeeId, string name, double hourlyRate, int workingHours)
        : base(employeeId, name, 0)
    {
        this.hourlyRate = hourlyRate;
        this.workingHours = workingHours;
    }

    public override double CalculateSalary()
    {
        return hourlyRate * workingHours;
    }
}
public class PartTimeEmployee : Employee
{
    private double fixedSalary;

    public PartTimeEmployee(int employeeId, string name, double fixedSalary)
        : base(employeeId, name, fixedSalary)
    {
        this.fixedSalary = fixedSalary;
    }

    public override double CalculateSalary()
    {
        return fixedSalary;
    }
}

