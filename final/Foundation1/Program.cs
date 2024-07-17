using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create some videos
        Video video1 = new Video("Introducing the SkyWalker Shoes", "Gadget World", 2400);
        video1.AddComment(new Comment("Jane", "Can they really make you fly?"));
        video1.AddComment(new Comment("John", "Looks cool, but is it safe?"));

        Video video2 = new Video("Unboxing the Infinite Battery Pack", "Tech Trends", 1800);
        video2.AddComment(new Comment("Bob", "If only this were real..."));
        video2.AddComment(new Comment("Charlie", "Great concept, would buy if it existed!"));

        Video video3 = new Video("Reviewing the Forever Pen", "Gadget Guru", 1500);
        video3.AddComment(new Comment("Sarah", "Imagine never buying another pen!"));
        video3.AddComment(new Comment("Mike", "Does it write underwater though?"));

        Video video4 = new Video("First Look: The Time Travel Watch", "Future Tech", 3300);
        video4.AddComment(new Comment("Emma", "I'd go back to the 80s!"));
        video4.AddComment(new Comment("Liam", "Seems legit..."));
        // List of videos
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display video information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"\t{comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}