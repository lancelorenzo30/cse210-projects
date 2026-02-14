public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    private Random _random;

    public ListingActivity() : base("Listing Activity","This activity helps you focus on the positive by listing as many things as you can.", 0)
    {
        _prompts.Add("> Who are people that you appreciate?");
        _prompts.Add("> What are personal strengths of yours?");
        _prompts.Add("> Who are people that you have helped this week?");
        _prompts.Add("> When have you felt the Holy Ghost this month?");
        _prompts.Add("> Who are some of your personal heroes?");

        _random = new Random();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> answers = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while ( DateTime.Now < endTime)
        {
          Console.Write("> ");
          string input = Console.ReadLine();
          if (!string.IsNullOrEmpty(input))
            {
                answers.Add(input);
            }  
        }

        _count = answers.Count;

        return answers;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");

        Console.WriteLine();
        Console.Write("You may begin in:");
        ShowCountDown(3);

        Console.WriteLine();
        List<string> userList = GetListFromUser();

        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();
    }
}