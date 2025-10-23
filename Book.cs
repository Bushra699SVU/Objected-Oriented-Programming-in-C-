// Book.cs
using System;
public class Book : LibraryItem
{
    public string Author { get; set; }
    public string ISBN { get; set; }

    public Book(string title, string author, string isbn) : base(title)
    {
        this.Author = author;
        this.ISBN = isbn;
    }

    // إعادة تعريف (Override) للدالة المجردة
    public override void DisplayDetails()
    {
        // 
        Console.WriteLine("--- Book ---");
        Console.WriteLine($"ID: {UniqueId}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Status: {GetStatus()}");
    }
}