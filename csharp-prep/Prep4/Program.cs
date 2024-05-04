using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        // List<string> words = new List<string>();
        // words.Add("phone");
        // words.Add("keyboard");
        // words.Add("mouse");

        // foreach (string word in words) {
        //     Console.WriteLine(word);
        // }

        // Console.WriteLine(words.Count);
        // for (int i = 0; i < words.Count; i++) {
        //     Console.WriteLine(words[i]);
        // }

        List<int> numbersList = new List<int>();
        int userNumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userNumber != 0) {
            Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0){
                numbersList.Add(userNumber);
            }
        }
        
        int sum = numbersList.Sum();
        double average = numbersList.Average();
        int largest = numbersList.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

        
        
    }
}