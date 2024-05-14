using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Journal.");
        //TODO You have $x unsaved entries 
        int userChoice;
        while (true) {
            displayMenu();
            userChoice = 0;
            try {
                userChoice = int.Parse(Console.ReadLine());
            } 
            catch (Exception) {
                Console.WriteLine("\nNot an int, please try again.\n");
            }
            
            if (userChoice == 1) {

            }
            else if (userChoice == 2) {

            }
            else if (userChoice == 3) {

            }
            else if (userChoice == 4) {

            }
            else if (userChoice == 5) {
                break;
            }
            else {
                Console.WriteLine("Not an option, please try again.");
            }
        }
        
    }

    public static void displayMenu() {
        Console.WriteLine("\n1. Add Journal Entry");
        Console.WriteLine("2. Display Entries");
        Console.WriteLine("3. Save journal state");
        Console.WriteLine("4. Load journal state from file");
        Console.WriteLine("5. Exit");
        Console.Write("Please select from the above options: (1, 2, 3...) ");
    }

}