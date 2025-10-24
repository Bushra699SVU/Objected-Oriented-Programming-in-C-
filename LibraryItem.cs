// LibraryItem.cs
using System;
// يمثل عنصراً عاماً في المكتبة، ويوفر خصائص مشتركة ووظائف مجردة
public abstract class LibraryItem : IManageable
{
    // --- حقول خاصة (private) لحماية البيانات ---
    private readonly string _uniqueId;
    private string _title;
    private bool _isBorrowed;

    // --- خاصية ساكنة لحساب العدد الإجمالي للعناصر ---
    public static int TotalItems { get; private set; }

    // --- خصائص عامة (Properties) للتحكم بالوصول ---
    public string UniqueId => _uniqueId;
    public string Title
    {
        get { return _title; }
        set
        {
            if (Validator.IsValidTitle(value))
            {
                _title = value;
            }
            else
            {
                // 
                throw new ArgumentException("Title cannot be empty.");
            }
        }
    }

    // --- تعريف التفويض والحدث ---
    public delegate void StatusChangeHandler(string message);
    public event StatusChangeHandler OnStatusChanged;

    // --- المُنشئ (Constructor) ---
    protected LibraryItem(string title)
    {
        _uniqueId = Guid.NewGuid().ToString().Substring(0, 8);
        this.Title = title;
        _isBorrowed = false;
        TotalItems++; // زيادة العداد الساكن مع كل عنصر جديد
    }

    public void BorrowItem()
    {
        if (!_isBorrowed)
        {
            _isBorrowed = true;
            // 
            OnStatusChanged?.Invoke($"Item '{Title}' has been borrowed.");
        }
    }

    public void ReturnItem()
    {
        if (_isBorrowed)
        {
            _isBorrowed = false;
            // 
            OnStatusChanged?.Invoke($"Item '{Title}' has been returned.");
        }
    }

    public string GetStatus()
    {
        // 
        return _isBorrowed ? "Borrowed" : "Available";
    }

    // دالة مجردة يجب على كل الفئات الفرعية تطبيقها
    public abstract void DisplayDetails();
}