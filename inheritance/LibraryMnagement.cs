/*Description: Model a Book system where Book is the superclass, and Author
is a subclass.
○ Tasks:
■ Define a superclass Book with attributes like Title and
PublicationYear.
■ Define a subclass Author with additional attributes like Name and Bio.
■ Create a method DisplayInfo() to show details of the book and its
author.

○ Goal: Practice single inheritance by extending the base class and adding more
specific details in the subclass.*/

using System;
public class Book
{
    public string Title { get; }
    public int PublicationYear { get; }

    public Book(string title, int publicationYear)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title cannot be empty.");

        if (publicationYear <= 0)
            throw new ArgumentException("Publication year must be valid.");

        Title = title;
        PublicationYear = publicationYear;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Publication Year: {PublicationYear}");
    }
}


public class Author : Book
{
    public string Name { get; }
    public string Bio { get; }

    public Author(
        string title,
        int publicationYear,
        string name,
        string bio
    ) : base(title, publicationYear)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Author name cannot be empty.");

        Name = name;
        Bio = bio;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Author Name: {Name}");
        Console.WriteLine($"Bio: {Bio}");
    }
}
