using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Joel Johnson", "Calc 1");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathassignment = new MathAssignment("Joel Johnson", "Calc 1", "4.5", "106, 122, 126, 128, 132");
        Console.WriteLine(mathassignment.GetSummary());
        Console.WriteLine(mathassignment.GetHomeWorkList());

        WritingAssignment writingassignment = new WritingAssignment("Joel Johnson", "YouTubing 101", "How to make a Waymo video");
        Console.WriteLine(writingassignment.GetSummary());
        Console.WriteLine(writingassignment.GetWritingInformation()); 
    }
}