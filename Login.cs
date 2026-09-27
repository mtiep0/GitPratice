using System;

class Program
{
    static void Main()
    {
        // Tài khoản và mật khẩu mẫu
        string validUsername = "admin";
        string validPassword = "123";

        Console.WriteLine("=== HE THONG DANG NHAP ===");

        Console.Write("Nhap ten dang nhap: ");
        string username = Console.ReadLine();

        Console.Write("Nhap mat khau: ");
        string password = Console.ReadLine();

        // Kiem tra thong tin dang nhap
        if (username == validUsername && password == validPassword)
        {
            Console.WriteLine("\n Dang nhap thanh cong! Xin chao " + username + ".");
        }
        else
        {
            Console.WriteLine("\n Dang nhap that bai: Sai ten dang nhap hoac mat khau.");
        }
    }
}