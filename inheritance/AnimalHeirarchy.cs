using System;

public class Animal
{
	public string Name { get; set; }
	public string Age { get; set; }
	public virtual void MakeSound()
	{
		Console.WriteLine("Animal makes sound");

	}
}
public class Dog : Animal
{
	public override void MakeSound()
	{
		Console.WriteLine("Dog Barks");
	}
}
public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("cat Meows");
    }
}
public class Bird : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Bird also sounds ");
    }
}