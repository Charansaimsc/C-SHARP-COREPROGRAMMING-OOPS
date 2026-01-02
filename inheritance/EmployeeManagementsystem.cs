using System;

public class Employee
{
	public string Name { get; set; }
	public int Id { get; set; }
	public double Salary { get; set; }
	public Employee(string Name,int Id,double Salary)
	{
		this.Name = Name;
		this.Id = Id;
		this.Salary = Salary;
	}
	public virtual void DisplayDetails()
	{
		Console.WriteLine(Name + "    " + Id + "      " + Salary);
	}
}
public class Manager : Employee
{

    public int TeamSize { get; set; }
	public Manager(int  TeamSize,string Name,int Id,double Salary ) : base(Name, Id, Salary)
	{
		  
		this.TeamSize = TeamSize;
	}
	public override void DisplayDetails()
	{
        base.DisplayDetails();

        Console.WriteLine(  "     " + TeamSize);
	}
}

public class Developer : Employee
{

    public string ProgrammingLanguage { get; set; }
    public Developer( string Name, int Id, double Salary, string ProgrammingLanguage) : base(Name, Id, Salary)
    {

        this.ProgrammingLanguage = ProgrammingLanguage;
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine( "     " + ProgrammingLanguage);
    }
}

public class Intern : Employee
{

    public string InternshipDuration { get; set; }
    public Intern( string Name, int Id, double Salary, string InternshipDuration) : base(Name, Id, Salary)
    {

        this.InternshipDuration = InternshipDuration;
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine(  "     " + InternshipDuration);
    }
}
