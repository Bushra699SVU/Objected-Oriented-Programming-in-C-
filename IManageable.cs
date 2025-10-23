// IManageable.cs
using System;
// الواجهة تحدد العقد الأساسي لأي عنصر يمكن إدارته في المكتبة
public interface IManageable
{
    void BorrowItem();
    void ReturnItem();
    string GetStatus();
}