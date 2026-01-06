using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int sum = 0;
        int average = 0;
        int largest = 0;
        Console.WriteLine("Enter integers one by one. Type '0' to finish:");

        int input = 1;
        while (input != 0)
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out input))
            {
                numbers.Add(input);
            }
        }

        foreach (int number in numbers)
        {
            sum += number;
        }

        if (numbers.Count > 0)
        {
            average = sum / numbers.Count;
            largest = numbers[0];
            foreach (int number in numbers)
            {
                if (number > largest)
                {
                    largest = number;
                }
            }
        }

        Console.WriteLine("The sum of the numbers is: " + sum);
        Console.WriteLine("The average of the numbers is: " + average);
        Console.WriteLine("The largest number is: " + largest);
    }
}