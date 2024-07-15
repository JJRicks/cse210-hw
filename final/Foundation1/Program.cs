using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create some videos
        Video video1 = new Video("Understanding C#", "Code Academy", 3600);
        video1.AddComment(new Comment("Jane", "Very informative, thanks!"));
        video1.AddComment(new Comment("John", "Great explanation."));
        video1.AddComment(new Comment("Alice", "Could use more examples."));

        Video video2 = new Video("Advanced C# Techniques", "Tech Guru", 4500);
        video2.AddComment(new Comment("Bob", "This is too advanced for me."));
        video2.AddComment(new Comment("Charlie", "Perfect, just what I needed!"));
        video2.AddComment(new Comment("Dave", "Thanks for the insights."));

        // List of videos
        List<Video> videos = new List<Video> { video1, video2 };

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