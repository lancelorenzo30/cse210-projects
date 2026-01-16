using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Entry question1 = new Entry();
        question1._promptText = "How am I feeling right now in just one word? Why did I choose that word?";
        Entry question2 = new Entry();
        question2._promptText = "What is one worry or thought from today that I want to leave on this page and let go of?";
        Entry question3 = new Entry();
        question3._promptText = "What is one thing that made me smile or laugh today?";
        Entry question4 = new Entry();
        question4._promptText = "What gave me energy today, and what drained my energy?";
        Entry question5 = new Entry();
        question5._promptText = "What is one thing I accomplished today that I'm proud of?";

        
    }
}