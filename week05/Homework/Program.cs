using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Darius Arius", "Algebra", "5.1", "1-10");
        WritingAssignment writingAssignment = new WritingAssignment("Joan Jones", "Literature", "The Great Gatsby Essay");

        Console.WriteLine("Math Assignment Summary:");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        Console.WriteLine();

        Console.WriteLine("Writing Assignment Summary:");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}