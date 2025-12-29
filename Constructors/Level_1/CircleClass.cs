using System;

public class Circle
{
	int radius;
	public Circle()
	{
		radius = 10;
	}
	public Circle(int radius)
	{
		this.radius = radius;
	}
	public void Display()
	{
		Console.WriteLine(radius);
	}
}
