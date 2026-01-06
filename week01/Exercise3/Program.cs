using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response = "yes";
        while (response.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int userGuess = 0;
            int guesses = 0;
            
            while (magicNumber != userGuess)
            {
                Console.Write("Guess the magic number (between 1 and 100): ");
                string userInput = Console.ReadLine();
                
                if (int.TryParse(userInput, out userGuess))
                {
                    if (userGuess < magicNumber)
                    {
                        Console.WriteLine("Higher!");
                        guesses++;
                    }
                    else if (userGuess > magicNumber)
                    {
                        Console.WriteLine("Lower!");
                        guesses++;
                    }
                    else
                    {
                        Console.WriteLine("Congratulations! You did it!");
                        guesses++;
                        Console.WriteLine($"You guessed the number in {guesses} attempts.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter an integar between 1 and 100.");
                }
            }
            Console.Write("Do you want to play again? (yes/no): ");
            response = Console.ReadLine();
        }
    }
}