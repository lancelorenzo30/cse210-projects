using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string strGrade = Console.ReadLine();
        int grade = int.Parse(strGrade);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        float remainder = grade % 10;

        if (remainder >= 7)
        {
            letter += "+";
        }
        else if (remainder < 3)
        {
            letter += "-";
        }
        else
        {
            letter += "";
        }

        if (letter == "A+" || letter == "A")
        {
            letter = "A";
        }
        else
        {
            letter = "A-";
        }

        if (letter == "F+" || letter == "F-")
        {
            letter = "F";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (grade >=70)
        {
            Console.WriteLine("Congratulations! You Passed!");
        }
        else
        {
            Console.WriteLine("It's okay, you can try again and I know you'll do better! I believe in you!");
        }
    }
}