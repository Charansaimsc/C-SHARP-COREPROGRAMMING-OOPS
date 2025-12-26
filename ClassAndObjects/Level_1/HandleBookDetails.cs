using System;

public class HandleBookDetails
{
	string Title;
	string AuthorName;
	int Price;

	public HandleBookDetails(string title,string authorName,int price)
	{
		Title= title;
		AuthorName= authorName;
		Price= price;
	}
	public void Display()
	{
		Console.WriteLine("Title : " + Title + "   AuthorName : " + AuthorName + "  Price" + Price);
	}
	
}
