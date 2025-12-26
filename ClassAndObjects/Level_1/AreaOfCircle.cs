using System;

class Circle
{
	 double Radius;
		public Circle(double radius)
	{
		Radius = radius; 
	}
	public double AreaCalculation(double radius)
	{
		return Math.PI * Radius * Radius;
	}
	public double Circumference(double radius)
	{
		return 2 * Math.PI * Radius;
	}
	public void Display()
	{
		Console.WriteLine(" Area : "+AreaCalculation(Radius));
		Console.WriteLine("Circumference : " + Circumference(Radius));
	}
}
