using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment1 = new Assignment("Lance Lorenzo", "CSE210");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(); 

        MathAssignment math1 = new MathAssignment("Lance Lorenzo", "Multiplication", "Section 9.1", "Problems 1-10");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine();
        Console.WriteLine(math1.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writing1 = new WritingAssignment("Lance Lorenzo", "European History", "The Cause of World War II by Mary Waters");
        Console.WriteLine(writing1.GetWritingInfo());
    }
}