using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your First Name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Please enter your Last Name:");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}