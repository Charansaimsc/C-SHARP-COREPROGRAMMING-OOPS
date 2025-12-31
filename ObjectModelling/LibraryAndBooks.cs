/*Description: Create a Library class that contains multiple Book objects. Model the
relationship such that a library can have many books, but a book can exist independently
(outside of a specific library).
Tasks:
● Define a Library class with a List<Book> collection.
● Define a Book class with attributes such as Title and Author.
● Demonstrate the aggregation relationship by creating books and adding them to
different libraries.
Goal: Understand aggregation by modeling a real-world relationship where the Library
aggregates Book objects.*/


using System;

public class Book
{
	public string Title {  get; set; }
public string Author {  get; set; }

	public Book(string Title,string Author)
	{
	this.Title = Title;
	this.Author = Author;
	}

}
public class Library
{
	public string LibraryName { get; set; }
	public List<Book> Books;
	public Library(string LibraryName)
	{
		this.LibraryName = LibraryName;
		Books = new List<Book>();
	}
	public void AddBook(Book book)
	{
		Books.Add(book);
	}
	public void Display()
	{
		for (int i = 0; i < Books.Count; i++)
		{
			Book book = Books[i];
			Console.WriteLine(book.Title + book.Author);
		}
	}
}
