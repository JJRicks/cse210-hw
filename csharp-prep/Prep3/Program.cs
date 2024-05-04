using System;
using System.Runtime.InteropServices;


class Program
{
    static void Main(string[] args)
    {
        bool stillPlaying = true;
        while (stillPlaying) {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int numGuesses = 0;
            int guess;
            do {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                numGuesses++;
                if (guess < magicNumber) {
                    Console.WriteLine("Higher");
                } else if (guess > magicNumber) {
                    Console.WriteLine("Lower");
                } else {
                    Console.WriteLine($"You guessed it! Guess count: {numGuesses}");
                }

            } while (guess != magicNumber);
            Console.Write("Would you like to play again? y/n ");
            string response = Console.ReadLine();
            if(response == "y") {
                ;
            } else {
                stillPlaying = false;
            }
        }
    }
}