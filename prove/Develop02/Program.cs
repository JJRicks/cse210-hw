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
        int unsavedEntries = 0;
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
                    unsavedEntries++;
                    break;
                case 2:
                    journal.displayEntries();
                    break;
                case 3:
                    journal.saveFile();
                    unsavedEntries = 0;
                    break;
                case 4:
                    journal.loadFile();
                    break;
                case 0:
                    if (unsavedEntries > 0) {
                        while (true) {
                            Console.Write($"You have {unsavedEntries} unsaved entry/entries. Are you sure you want to exit? (y/n) ");
                            string userExitChoice = Console.ReadLine().ToLower();
                            if (userExitChoice == "y") {
                                Console.WriteLine("Exiting...");
                                return;
                            }
                            else if (userExitChoice == "n") {
                                break;
                            }
                            else {
                                Console.WriteLine("Invalid input, please try again.");
                            }
                        }

                    }
                    else {
                        Console.WriteLine("Exiting...");
                        return;
                    }
                    break;
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