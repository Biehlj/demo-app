using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Login Application");

        // Prompt for username
        Console.Write("Enter your email address: ");
        string? username = Console.ReadLine();

        // Validate username
        if (username != null && IsValidEmail(username))
        {
            Console.WriteLine("Login successful!");
        }
        else
        {
            Console.WriteLine("Invalid email address. Please try again.");
        }
    }

    static bool IsValidEmail(string email)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == email;
        }
        catch
        {
            return false;
        }
    }
}

