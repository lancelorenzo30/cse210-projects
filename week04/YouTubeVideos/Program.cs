using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn How To Learn", "Joseph Smith Jr.", 300);
        video1.CommentAdder(new Comment("Moses36", "Great Job!"));
        video1.CommentAdder(new Comment("1Nephi37", "Awesome! Now there is a way!"));
        video1.CommentAdder(new Comment("Laman&Lemuel", "It's too Hard to understand!"));

        videos.Add(video1);

        Video video2 = new Video("Great War Tactics", "Captain Moroni", 1800);

        video2.CommentAdder(new Comment("2000StriplingWarriors", "Very effective strategy!"));
        video2.CommentAdder(new Comment("TheGadiantonRobbers", "Boo!"));
        video2.CommentAdder(new Comment("Teancum", "The leader I will follow!"));

        videos.Add(video2);

        Video video3 = new Video("The Book of Mormon", "Mormon", 15000);

        video3.CommentAdder(new Comment("TheLastDecenter", "Now I pass it for the future saints"));
        video3.CommentAdder(new Comment("ModernSaint123", "It's scarily long, hope I could finish"));
        video3.CommentAdder(new Comment("ModernLeader456", "Bear with it! It's the most important thing to know in life and it's worth it!"));

        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}