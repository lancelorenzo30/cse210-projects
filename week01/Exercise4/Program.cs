using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers =  new List<int>();
        int addNumber = 0;

        do
        {
            Console.Write("Enter number: ");
            string number = Console.ReadLine();
            addNumber = int.Parse(number);    

            if (addNumber != 0)
            {
                numbers.Add(addNumber);
            }
        } while (addNumber != 0);
        
        int sum = 0;
        int count = 0;
        int biggestNumber = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            count += 1;
            if (numbers[i] > biggestNumber)
            {
                biggestNumber = numbers[i];
            }
        }

        double average = (double)sum / count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {biggestNumber}");
    }
}