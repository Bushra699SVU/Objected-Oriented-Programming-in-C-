// Validator.cs
using System;
// فئة ساكنة (Static Class) توفر دوال مساعدة دون الحاجة لإنشاء كائن منها
public static class Validator
{
    public static bool IsValidTitle(string title)
    {
        return !string.IsNullOrWhiteSpace(title);
    }

    public static bool IsValidISBN(string isbn)
    {
        // مجرد مثال بسيط للتحقق
        return !string.IsNullOrWhiteSpace(isbn) && isbn.Length >= 10;
    }
}