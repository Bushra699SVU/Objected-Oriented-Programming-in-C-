// Dvd.cs
using System;
public class Dvd : LibraryItem
{
    public int DurationMinutes { get; set; }
    public string Director { get; set; }

    public Dvd(string title, string director, int duration) : base(title)
    {
        this.Director = director;
        this.DurationMinutes = duration;
    }

    // إعادة تعريف (Override) للدالة المجردة
    public override void DisplayDetails()
    {
        // 
        Console.WriteLine("--- DVD ---");
        Console.WriteLine($"ID: {UniqueId}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Director: {Director}");
        Console.WriteLine($"Duration: {DurationMinutes} mins");
        Console.WriteLine($"Status: {GetStatus()}");
    }
}