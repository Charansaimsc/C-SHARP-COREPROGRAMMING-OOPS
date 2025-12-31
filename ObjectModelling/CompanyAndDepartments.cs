/*Description: A Company has several Department objects, and each department contains
Employee objects. Model this using composition, where deleting a Company should also
delete all departments and employees.
Tasks:

● Define a Company class that contains multiple Department objects.
● Define an Employee class within each Department.
● Show the composition relationship by ensuring that when a Company object is
deleted, all associated Department and Employee objects are also removed.
Goal: Understand composition by implementing a relationship where Department and
Employee objects cannot exist without a Company.*/



using System;
using System.Collections.Generic;

public class Employee
{
    public string EmployeeName { get; set; }

    public Employee(string name)
    {
        EmployeeName = name;
    }
}

public class Department
{
    public string DepartmentName { get; set; }
    public List<Employee> Employees { get; set; }

    public Department(string departmentName)
    {
        DepartmentName = departmentName;
        Employees = new List<Employee>();
    }

    public void AddEmployee(string name)
    {
        Employees.Add(new Employee(name));
    }
}

public class Company
{
    public string CompanyName { get; set; }
    public List<Department> Departments { get; set; }

    public Company(string companyName)
    {
        CompanyName = companyName;
        Departments = new List<Department>();
    }

    public void AddDepartment(string name)
    {
        Departments.Add(new Department(name));
    }
}
