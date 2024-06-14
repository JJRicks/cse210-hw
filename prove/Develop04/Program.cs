using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args) {
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;
        
        while(true) {
            Console.Clear();
            Console.WriteLine("Menu options: ");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Show stats");
            Console.WriteLine("    5. Quit");

            Console.Write("Select a choice from the menu: ");

            // may or may not implement user input validation
            int userChoice = int.Parse(Console.ReadLine());

            switch(userChoice) {
                case 1:
                    BreathingActivity breathingsession = new BreathingActivity();
                    breathingsession.doSession();
                    breathingCount++;
                    break;
                case 2:
                    ReflectingActivity reflectingsession = new ReflectingActivity();
                    reflectingsession.doSession();
                    reflectingCount++;
                    break;
                case 3:
                    ListingActivity listingsession = new ListingActivity();
                    listingsession.doSession();
                    listingCount++;
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Activity stats: ");
                    Console.WriteLine($"Breathing sessions: {breathingCount}");
                    Console.WriteLine($"Reflecting sessions: {reflectingCount}");
                    Console.WriteLine($"Listing sessions: {listingCount}");

                    Activity activity = new Activity();
                    activity.showSpinner(5);
                    break;
                case 5:
                    Console.WriteLine("Quitting...");
                    return;

            }
        
        
        }    
    }
}