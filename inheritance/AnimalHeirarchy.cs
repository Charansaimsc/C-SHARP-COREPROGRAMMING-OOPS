using System;

public class Animal
{
	public string Name { get; set; }
	public int  Age { get; set; }
	public Animal(string Name,int Age)
	{
		this.Name = Name;
		this.Age = Age;
	}
	public void Display()
	{
		Console.WriteLine(Name + " " + Age);
	}
	public virtual void MakeSound()
	{
		Console.WriteLine("Animal makes sound");

	}
}
public class Dog : Animal
{
	public Dog(string Name, int age) : base(Name, age) { }
	public override void MakeSound()
	{
		base.Display();
		Console.WriteLine("Dog Barks");
	}
}
public class Cat : Animal
{

    public Cat(string Name, int age) : base(Name, age) { }
    public override void MakeSound()
    {

        base.Display();
        Console.WriteLine("cat Meows"+"\n");
    }
}
public class Bird : Animal
{

    public Bird(string Name, int age) : base(Name, age) { }
    public override void MakeSound()
    {

        base.Display();
        Console.WriteLine("Bird also sounds ");
    }
}