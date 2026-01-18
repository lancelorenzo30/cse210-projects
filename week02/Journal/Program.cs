using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        promptGenerator._prompts = new List<string>
        {
        "How am I feeling right now in just one word? Why did I choose that word?",
        "What is one worry or thought from today that I want to leave on this page and let go of?",
        "What is one thing that made me smile or laugh today?",
        "What gave me energy today, and what drained my energy?",
        "What is one thing I accomplished today that I'm proud of?",
        };

        int userChoice = 0;

        while (userChoice !=5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                theJournal.AddEntry(newEntry);
            }

            else if (userChoice == 2)
            {
                theJournal.DisplayAll();
            }

            else if (userChoice == 3)
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);
            }

            else if (userChoice == 4)
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                theJournal.LoadFromFile(file);
            }
        }
    }
}