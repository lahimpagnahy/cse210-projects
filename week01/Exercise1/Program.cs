using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello There!");

        // Add blank line
        Console.WriteLine("");

         // Asking the user to enter the first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Asking the user to enter the last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Add blank line
        Console.WriteLine("");

        // Display the identity of the user in the style of James Bond
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");

    }
}