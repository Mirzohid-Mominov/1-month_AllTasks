﻿class Program
{
    static void Main()
    {
        Console.Write("Do you want to include numbers (true/false): ");
        bool Numbers = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Need letters (true/false): ");
        bool Letters = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Need symbols (true/false): ");
        bool Symbols = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Password length: ");
        int passwordLength = Convert.ToInt32(Console.ReadLine());

        string password = GeneratePassword(Numbers, Letters, Symbols, passwordLength);
        Console.WriteLine("Generated password: " + password);
    }

    static string GeneratePassword(bool includeNumbers, bool includeLetters, bool includeSymbols, int passwordLength)
    {
        const string numbers = "0123456789";
        const string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string symbols = "!@#$%^&*()_-+=<>?";

        Random random = new Random();

        string characters = "";

        if (includeNumbers)
        {
            characters += numbers;
        }

        if (includeLetters)
        {
            characters += letters;
        }

        if (includeSymbols)
        {
            characters += symbols;
        }

        if (characters.Length == 0)
        {
            throw new Exception("Choose one section!");
        }

        char[] passwordChars = new char[passwordLength];

        for (int i = 0; i < passwordLength; i++)
        {
            int randomIndex = random.Next(characters.Length);
            passwordChars[i] = characters[randomIndex];
        }

        return new string(passwordChars);
    }
}