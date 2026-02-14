using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int time)
    {
        _name = name;
        _description = description;
        _duration = time;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you Like for your session? ");
        string answer = Console.ReadLine();
        _duration = int.Parse(answer);

        Console.Clear();
        Console.WriteLine("Get ready...");

        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of {_name}");
        ShowSpinner(5);

        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string loading = animationStrings[i];
            Console.Write(loading);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int timer = seconds; timer > 0; timer --)
        {
            Console.Write(timer);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int GetDuration()
    {
        return _duration;
    }
}