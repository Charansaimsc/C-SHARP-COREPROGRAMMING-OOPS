using System;

class EmployeeDetails
{
	string Name;
	int Id;
	double Salary;
	public EmployeeDetails(string name,int id ,double salary)
	{
		this.Name = name;
		this.Id = id;
		this.Salary = salary;
	}
	public void DisplayDetails()
	{
		Console.WriteLine("name : "+ Name+"Id : "+Id+"Salary : "+ Salary);
	}
}
