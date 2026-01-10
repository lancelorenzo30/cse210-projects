using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(0,100);

        int guessNumber = 0;

        do
        {            
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);
            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber == magicNumber)
            {
                Console.WriteLine("You guessed right!");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        }  while (guessNumber != magicNumber);
    }
}