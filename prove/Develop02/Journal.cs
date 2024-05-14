using System;
using System.Runtime.CompilerServices;
using System.Text.Json;

class Journal {

    // declare variables
    // entry list
    List<Entry> entries = new List<Entry>();

    public Journal() {

    }

    public void addEntry() {
        // TODO pull from the prompts class, possibly interface with ChatGPT API given time
        // interact with the entries class, add user inputs
        Entry entry = new Entry();
        Console.WriteLine("\nInsert Prompt Here. "); // TODO maybe fancy up the formatting?
        Console.Write("Journal entry title: ");
        
        // add logic and loop to validate entry title, try catch with get set? is that stupid idk
        entry.Title = Console.ReadLine();

        Console.Write("Journal entry: ");
        entry.Body = Console.ReadLine();

        entries.Add(entry);
    }
    public void displayEntries() {
        // show a truncated list of all current entries and then 
        Console.WriteLine("\nPlease select an entry to read: (1, 2, 3... 0 to exit)");
        // validate input 
        while (true){
            try {
                foreach (Entry entry in entries) {
                    Console.WriteLine($"#{entry.EntryNumber}: {entry.Title}");
                }   
                Console.Write("Entry: ");
                int userSelectedEntry = int.Parse(Console.ReadLine());
                if (userSelectedEntry == 0) {
                    break;
                }
                else {
                    Console.WriteLine($"\n{entries[userSelectedEntry - 1].Title}:");
                    Console.WriteLine($"{entries[userSelectedEntry - 1].Body}\n");
                }
            }
            catch (Exception) {
                Console.WriteLine("Invalid input, please try again.");
            }
        }
    }
}