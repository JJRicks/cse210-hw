using System;
class Program
{
    static void Main()
    {
        Event lecture = new LectureEvent("C# Fundamentals", "Introduction to C#", DateTime.Now.AddDays(10), "10:00 AM", new Address("123 Elm St", "Metropolis", "MT", "USA"), "John Doe", 100);
        Event reception = new ReceptionEvent("Tech Mixer", "Networking event for tech enthusiasts", DateTime.Now.AddDays(20), "6:00 PM", new Address("456 Oak St", "Gotham", "GT", "USA"), "rsvp@techmixer.com");
        Event outdoor = new OutdoorGatheringEvent("Summer Festival", "Annual community festival", DateTime.Now.AddDays(30), "1:00 PM", new Address("789 Pine St", "Star City", "SC", "USA"), "Sunny");

        PrintEventDetails(lecture);
        PrintEventDetails(reception);
        PrintEventDetails(outdoor);
    }

    static void PrintEventDetails(Event eventInstance)
    {
        Console.WriteLine("\nStandard details");
        Console.WriteLine(eventInstance.GetStandardDetails());

        Console.WriteLine("\nFull details");
        Console.WriteLine(eventInstance.GetFullDetails());

        Console.WriteLine("Short description:");
        Console.WriteLine(eventInstance.GetShortDescription());
        Console.WriteLine();
    }
}