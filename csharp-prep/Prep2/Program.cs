using System;
using System.Runtime.InteropServices;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int gradePercentage = int.Parse(Console.ReadLine());
        string letterGrade = "";

        if(gradePercentage >= 90) {
            // I wanna use Java bracket convention, it looks better to me lol
            letterGrade = "A";
        } else if (gradePercentage >= 80) {
            letterGrade = "B";
        } // okay, fine 
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercentage >= 60) 
        {
            letterGrade = "D";
        }
        else if (gradePercentage < 60)
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your letter grade is: {letterGrade}");

        if (letterGrade == "A" || letterGrade == "B" || letterGrade == "C")
        {
            Console.WriteLine("Congrats, you passed!");
        }
        else {
            Console.WriteLine("Sorry! You didn't pass. Try again!");
        }
    }
}