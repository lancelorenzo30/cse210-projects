public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions =  new List<string>();

    private Random _random;

    public ReflectingActivity() : base("Reflecting Activity", "This activity helps you reflect on times when you showed strength and resilience.", 0)
    {
        _prompts.Add("> Think of a time when you stood up for someone else.");
        _prompts.Add("> Think of a time when you did something really difficult.");
        _prompts.Add("> Think of a time when you helped someone in need.");
        _prompts.Add("> Think of a time when you did something truly selfless.");

        _questions.Add("> Why was this experience meaningful to you?");
        _questions.Add("> Have you ever done anything like this before?");
        _questions.Add("> How did you get started?");
        _questions.Add("> How did you feel when it was complete?");
        _questions.Add("> What made this time different than other times when you were not as succesful?");
        _questions.Add("> What is your favorite thing about this experience?");
        _questions.Add("> What could you learn from this experience that applies to other situations?");
        _questions.Add("> What did you learn about yourself through this experience?");
        _questions.Add("> How can you keep this experience in mind in the future?");

        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetQuestionPrompt()
    {
        int index = _random.Next(_questions.Count);
        return _questions[index];
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        Console.WriteLine($"--- {GetRandomPrompt()} ---");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in:");
        ShowCountDown(3);

        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetQuestionPrompt());
            ShowSpinner(5);
        }

        Console.WriteLine();
        DisplayEndingMessage();
    }
}