using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("17 Feb 2026", 30, 3.0));
        activities.Add(new Cycling("17 Feb 2026", 30, 10.0));
        activities.Add(new Swimming("17 Feb 2026", 30, 9));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.Getsummary());
        }
    }
}