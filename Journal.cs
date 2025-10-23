// Journal.cs
using System;
public class Journal : LibraryItem
{
    public string Publisher { get; set; }
    public int IssueNumber { get; set; }

    public Journal(string title, string publisher, int issue) : base(title)
    {
        this.Publisher = publisher;
        this.IssueNumber = issue;
    }

    // إعادة تعريف (Override) للدالة المجردة
    public override void DisplayDetails()
    {
        // 
        Console.WriteLine("--- Journal ---");
        Console.WriteLine($"ID: {UniqueId}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Publisher: {Publisher}");
        Console.WriteLine($"Issue No: {IssueNumber}");
        Console.WriteLine($"Status: {GetStatus()}");
    }
}