using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Journal.");
        //TODO You have $x unsaved entries 
        Journal journal = new Journal();
        int userChoice;
        while (true) {
            displayMenu();
            userChoice = 0;
            try {
                userChoice = int.Parse(Console.ReadLine());
            } 
            catch (Exception) {
                Console.WriteLine("\nNot an int, please try again.\n");
                continue; 
            }
            
            switch (userChoice) {
                case 1:
                    journal.addEntry();
                    break;
                case 2:
                    journal.displayEntries();
                    break;
                case 3:
                    journal.saveFile();
                    break;
                case 4:
                    journal.loadFile();
                    break;
                case 0:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Not an option, please try again.");
                    break;
            }
        }
        
    }

    public static void displayMenu() {
        Console.WriteLine("\n1. Add Journal Entry");
        Console.WriteLine("2. Display Entries");
        Console.WriteLine("3. Save journal state");
        Console.WriteLine("4. Load journal state from file");
        Console.Write("Please select from the above options: (1, 2, 3... 0 to exit) ");
    }

}