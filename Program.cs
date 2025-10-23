// Program.cs
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // --- إظهار الوراثة وتعدد الأشكال ---
        Console.WriteLine("--- Polymorphism Demo ---");
        List<LibraryItem> items = new List<LibraryItem>
        {
            // تم استخدام بيانات باللغة الإنجليزية
            new Book("The C# Player's Guide", "RB Whitaker", "978-0985580131"),
            new Dvd("Inception", "Christopher Nolan", 148),
            new Journal("Nature", "Springer Nature", 589)
        };

        foreach (var item in items)
        {
            item.DisplayDetails();
            Console.WriteLine();
        }

        // --- إظهار الأحداث ---
        Console.WriteLine("\n--- Events Demo ---");
        var bookToTest = items[0] as Book;

        // الاشتراك في الحدث
        bookToTest.OnStatusChanged += Library_OnStatusChanged;

        bookToTest.BorrowItem();
        bookToTest.ReturnItem();

        // إلغاء الاشتراك في الحدث
        bookToTest.OnStatusChanged -= Library_OnStatusChanged;

        // --- إظهار الأعضاء الساكنة ---
        Console.WriteLine("\n--- Static Members Demo ---");
        Console.WriteLine($"Total library items created: {LibraryItem.TotalItems}");

        bool isValid = Validator.IsValidISBN("978-0985580131");
        Console.WriteLine($"Is ISBN valid? {isValid}");

        Console.ReadKey();
    }

    // هذه الدالة هي "معالج الحدث"
    private static void Library_OnStatusChanged(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        // 
        Console.WriteLine($"[EVENT NOTIFICATION]: {message}");
        Console.ResetColor();
    }
}