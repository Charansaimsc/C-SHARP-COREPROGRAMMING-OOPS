/*Description: Model a restaurant system where Person is the superclass and
Chef and Waiter are subclasses. Both Chef and Waiter should implement a
Worker interface that requires a PerformDuties() method.
○ Tasks:
■ Define a superclass Person with attributes like Name and Id.
■ Create an interface Worker with a method PerformDuties().
■ Define subclasses Chef and Waiter that inherit from Person and
implement the Worker interface, each providing a unique implementation
of PerformDuties().

○ Goal: Practice hybrid inheritance by combining inheritance and interfaces, giving
multiple behaviors to the same objects.*/


using System;

public class Persons
{
    public string Name { get; set; }
    public int Id { get; set; }

    public Persons(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public void DisplayPersonInfo()
    {
        Console.WriteLine($"Name: {Name}, Id: {Id}");
    }
}

public interface Worker
{
    void PerformDuties();
}

public class Chef : Persons, Worker
{
    public Chef(string name, int id) : base(name, id)
    {
    }

    public void PerformDuties()
    {
        Console.WriteLine("Chefcooking ,,...");
    }
}

public class Waiter : Persons, Worker
{
    public Waiter(string name, int id) : base(name, id)
    {
    }

    public void PerformDuties()
    {
        Console.WriteLine("Busy.");
    }
}



