using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        while (true) {
            
            Console.WriteLine("Welcome to scripture memorizer. Please select from the following options: (1, 2, 3 or quit)");
            Console.WriteLine("1: Add a scripture to the vault");
            Console.WriteLine("2: Display a scripture for memorization");
            Console.WriteLine("3 or quit: Exit the program");
            Console.Write("Selection: ");
            
            string userChoice = Console.ReadLine();
            
            switch (userChoice) {
                case "1": // add a scripture to the vault
                    
                    break; 
                case "2": // display a scripture for memorization
                    break;
                case "3": // quit
                    return;
                case "quit": // other way to quit
                    return;
                default:
                    Console.WriteLine("\nNot a vaild menu selection, please try again.\n");
                    break;
            }
        }
    }
}