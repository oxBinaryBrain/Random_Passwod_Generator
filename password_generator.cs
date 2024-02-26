using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Enter the length of the password: ");
        int length = Convert.ToInt32(Console.ReadLine());
        
        string password = GeneratePassword(length);
        Console.WriteLine("Generated Password: " + password);
    }

    static string GeneratePassword(int length)
    {
        const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+-=";
        StringBuilder password = new StringBuilder();
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            int randomIndex = random.Next(validChars.Length);
            password.Append(validChars[randomIndex]);
        }

        return password.ToString();
    }
}

