using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args) {
        while(true) {
            Console.Clear();
            Console.WriteLine("Menu options: ");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Quit");

            Console.Write("Select a choice from the menu: ");

            // may or may not implement user input validation
            int userChoice = int.Parse(Console.ReadLine());

            switch(userChoice) {
                case 1:
                    BreathingActivity breathingsession = new BreathingActivity();
                    breathingsession.doSession();
                    break;
                case 2:
                    ReflectingActivity reflectingsession = new ReflectingActivity();
                    reflectingsession.doSession();
                    break;
                case 3:
                    ListingActivity listingsession = new ListingActivity();
                    listingsession.doSession();
                    break;
                case 4:
                    Console.WriteLine("Quitting...");
                    return;

            }
        
        
        }    
    }
}