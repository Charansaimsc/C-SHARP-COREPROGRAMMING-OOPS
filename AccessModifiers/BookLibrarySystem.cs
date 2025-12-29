using System;

/*Design a Book class with:
o ISBN (public)
o title (protected)
o author (private)
● Implement methods to:
o Set and get the author name.
o Create a subclass EBook to access ISBN and title and demonstrate access*/



class Book
{
    
    public string ISBN;

    protected string title;

    private string author;

    public Book(string isbn, string title, string author)
    {
        this.ISBN = isbn;
        this.title = title;
        this.author = author;
    }

    // Setter method for author (private)
    public void SetAuthor(string author)
    {
        this.author = author;
    }

    // Getter method for author (private)
    public string GetAuthor()
    {
        return author;
    }
}

// Derived Class
class EBook : Book
{
    public string fileFormat;

    // Constructor
    public EBook(string isbn, string title, string author, string fileFormat)
        : base(isbn, title, author)
    {
        this.fileFormat = fileFormat;
    }

    // Method to demonstrate access modifiers
    public void DisplayEBookDetails()
    {
        Console.WriteLine("ISBN        : " + ISBN);   
        Console.WriteLine("Title       : " + title);                 
        Console.WriteLine("Author      : " + GetAuthor());
        Console.WriteLine("File Format : " + fileFormat);
    }
}

