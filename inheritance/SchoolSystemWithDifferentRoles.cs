/*Description: Create a hierarchy for a school system where Person is the
superclass, and Teacher, Student, and Staff are subclasses.

○ Tasks:
■ Define a superclass Person with common attributes like Name and Age.
■ Define subclasses Teacher, Student, and Staff with specific
attributes (e.g., Subject for Teacher and Grade for Student).
■ Each subclass should have a method like DisplayRole() that
describes the role.

○ Goal: Demonstrate hierarchical inheritance by modeling different roles in a
school, each with shared and unique characteristics.*/

using System;

public class Person
{
    public string Name { get; }
    public int Age { get; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void DisplayRole()
    {
        Console.WriteLine("Role: Person");
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Age  : {Age}");
    }
}

public class Teacher : Person
{
    public string Subject { get; }

    public Teacher(string name, int age, string subject)
        : base(name, age)
    {
        Subject = subject;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Role: Teacher");
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Subject : {Subject}");
    }
}
public class Student : Person
{
    public string Grade { get; }

    public Student(string name, int age, string grade)
        : base(name, age)
    {
        Grade = grade;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Role: Student");
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Grade : {Grade}");
    }
}
public class Staff : Person
{
    public string Department { get; }

    public Staff(string name, int age, string department)
        : base(name, age)
    {
        Department = department;
    }

    public override void DisplayRole()
    {
        Console.WriteLine("Role: Staff");
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Department : {Department}");
    }
}
