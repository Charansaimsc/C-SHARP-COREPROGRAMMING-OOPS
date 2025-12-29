using System;

public class Book
{
	string title;
	string author;
	int price;
	public Book()
	{
		title = "charan";
		author = "sai";
		price = 100;
	}
	public Book(string title,string author,int price)
	{
		this.title = title;
		this.author = author;
		this.price =price;

	}

	public void Display()
	{
		Console.WriteLine(title + author + price);
	}
}
