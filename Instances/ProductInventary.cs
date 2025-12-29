using System;

public class Product
{
	string productName;
	int price;
	static int totalStudents;
	public Product(string productName,int price)
	{
		this.productName = productName;
		this.price = price;
		totalStudents++;
    }
	public void DisplayProductDetails()
	{
		Console.WriteLine(productName + "   " + price);
	}
	public static void DisplayTotalStudents()
	{
		Console.WriteLine(totalStudents);
	}
	
}
