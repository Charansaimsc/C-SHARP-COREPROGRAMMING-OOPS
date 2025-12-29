/*Library Book System
o Create a Book class with attributes title, author, price, and availability.
o Implement a method BorrowBook() to borrow a book.*/


using System;

class Book
{
    // Attributes (Fields)
    public string Title;
    public string Author;
    public double Price;
    public bool IsAvailable;

    // Constructor
    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
        IsAvailable = true; // Book is available initially
    }

    // Method to borrow a book
    public void BorrowBook()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine($"You have successfully borrowed '{Title}'.");
        }
        else
        {
            Console.WriteLine($"Sorry, '{Title}' is currently not available.");
        }
    }

    // Method to display book details
    public void DisplayDetails()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Available: " + IsAvailable);
        Console.WriteLine();
    }
}

