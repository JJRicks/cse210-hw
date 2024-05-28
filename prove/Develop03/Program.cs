using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference();
        
        //Console.Clear();
        while (true) {
            
            Console.WriteLine("\nWelcome to scripture memorizer. Please select from the following options: (1, 2, 3 or quit)");
            Console.WriteLine("1: Add a scripture to the database");
            Console.WriteLine("2: Display a random scripture for memorization");
            Console.WriteLine("3: Display a specific scripture for memorization");
            Console.WriteLine("4: Display a list of all scriptures in the database");
            Console.WriteLine("quit: Exit the program");
            Console.Write("Selection: ");
            
            string userChoice = Console.ReadLine();
            
            switch (userChoice) {
                case "1": // add a scripture to the database
                    reference.addScripture();
                    break; 
                case "2": // display a random scripture for memorization
                    break;
                case "3":  // display a specific scripture for memorization
                    
                    int chosenScripture;
                    Console.WriteLine("\nWhich scripture would you like to work on? Here is the current list: ");
                    Console.WriteLine(reference.listAllScriptures());
                    // TODO add a part saying which verses do you want
                    Console.Write("Chosen scripture (1, 2, 3, 4, etc.): ");
                    chosenScripture = int.Parse(Console.ReadLine()) - 1;
                    
                    int[] chosenVerses;
                    string userVerseChooseinput;
                    Console.Write("Which verses from the scripture would you like to practice? (type each verse # with a space in between. Ex: 5 6 7): ");
                    userVerseChooseinput = Console.ReadLine();
                    // TODO trim spaces lol
                    chosenVerses = userVerseChooseinput.Split(' ').Select(int.Parse).ToArray();
                    
                    reference.memorizeScripture(chosenScripture, chosenVerses);
                    break; 

                case "4":
                    Console.WriteLine($"\n{reference.listAllScriptures()}");
                    break;
                case "quit": // other way to quit
                    return;
                default:
                    Console.WriteLine("\nNot a vaild menu selection, please try again.\n");
                    break;
            }
        }
    }
}