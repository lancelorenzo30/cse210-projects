using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Option:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select achoice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                
                case "2":
                    new ReflectingActivity().Run();
                    break;

                case "3":
                    new ListingActivity().Run();
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid Choice. Press Enter to try again.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}