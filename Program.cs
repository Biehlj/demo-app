using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Login Application");

        bool isValidEmail = false;
        bool isValidPassword = false;
        string? username = null;
        string? password = null;

        while (!isValidEmail)
        {
            // Prompt for username
            Console.Write("Enter your email address: ");
            username = Console.ReadLine();

            // Validate username 
            if (username != null)
            {
                isValidEmail = IsValidEmail(username);
            }

            if (!isValidEmail)
            {
                Console.WriteLine("Invalid email address. Please try again.");
            }
        }

        while (!isValidPassword)
        {
            // Prompt for password
            Console.Write("Enter your password: ");
            password = Console.ReadLine();

            // Validate password
            if (password != null)
            {
                isValidPassword = password.Length >= 8;
            }

            if (!isValidPassword)
            {
                Console.WriteLine("Invalid password. Please try again.");
            }
        }

        Console.WriteLine("Login successful!");
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

