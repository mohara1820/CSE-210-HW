using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store all videos
        List<Video> videos = new List<Video>();

        // Create Video 1
        Video video1 = new Video("How to Cook Pasta", "Chef John", 300);
        video1.AddComment(new Comment("Alice", "This recipe is amazing!"));
        video1.AddComment(new Comment("Bob", "I tried it yesterday and loved it."));
        video1.AddComment(new Comment("Charlie", "Great tips, thanks!"));
        videos.Add(video1);

        // Create Video 2
        Video video2 = new Video("Top 10 Coding Tips", "Tech Guru", 600);
        video2.AddComment(new Comment("David", "Very helpful for beginners."));
        video2.AddComment(new Comment("Emily", "I learned so much from this."));
        video2.AddComment(new Comment("Frank", "Awesome tips, keep it up!"));
        videos.Add(video2);

        // Create Video 3
        Video video3 = new Video("Travel Vlog: Japan", "Globe Trotter", 900);
        video3.AddComment(new Comment("Grace", "Japan looks beautiful!"));
        video3.AddComment(new Comment("Hannah", "Adding this to my travel list."));
        video3.AddComment(new Comment("Ian", "Great vlog, well edited!"));
        videos.Add(video3);

        // Loop through and display video details
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetComment()}");
            }
            Console.WriteLine(new string('-', 40)); // Separator
        }

        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}