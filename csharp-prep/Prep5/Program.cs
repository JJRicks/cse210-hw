using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome() {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName(){
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }
        static int PromptUserNumber() {
            Console.Write("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }
        static int SquaredNumber(int userNumber) {
            return userNumber * userNumber;
        }
        static void DisplayResult(string userName, int userNumberSquared){
            Console.WriteLine($"{userName}, the square of your number is {userNumberSquared}");
        }
    
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredUserNumber = SquaredNumber(userNumber);
        DisplayResult(userName, squaredUserNumber);

    }
}