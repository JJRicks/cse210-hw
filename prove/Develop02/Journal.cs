using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Diagnostics.Tracing;
using System.Security;

class Journal {

    // declare variables
    // entry list
    List<Entry> entries = new List<Entry>();
    Prompt entryPrompt = new Prompt();
 
    DateTime theCurrentTime = DateTime.Now;



    public Journal() {

    }

    public void addEntry() {
        Entry entry = new Entry();
        // pull from the prompts class
        string dateText = theCurrentTime.ToShortDateString();
        string selectedPrompt = entryPrompt.GetPrompt();
        Console.WriteLine($"\nExample prompt: {selectedPrompt}");
        // interact with the entries class, add user inputs
        
        Console.Write("Journal entry title: ");
        
        // add logic and loop to validate entry title, try catch with get set? is that stupid idk
        entry.Title = Console.ReadLine();

        Console.Write("Journal entry: ");
        entry.Body = Console.ReadLine();
        entry.Prompt = selectedPrompt;
        entry.Date = dateText;

        entries.Add(entry);
    }
    public void displayEntries() {
        // show a truncated list of all current entries and then 
        Console.WriteLine("\nPlease select an entry to read: (1, 2, 3... 0 to exit)");
        // validate input 
        while (true){
            try {
                foreach (Entry entry in entries) {
                    Console.WriteLine($"#{entry.EntryNumber} {entry.Date}: {entry.Title}");
                }   
                Console.Write("Entry: ");
                int userSelectedEntry = int.Parse(Console.ReadLine());
                if (userSelectedEntry == 0) {
                    break;
                }
                else {
                    Console.WriteLine($"\n{entries[userSelectedEntry - 1].Title} - {entries[userSelectedEntry - 1].Date}");
                    Console.WriteLine($"{entries[userSelectedEntry - 1].Prompt} - {entries[userSelectedEntry - 1].Body}\n");
                }
            }
            catch (Exception) {
                Console.WriteLine("Invalid input, please try again.");
            }
        }
    }
    public void saveFile() {

        string fileName = "Journal_" + DateTime.Now.ToString("yyyy_M_dd__HH_mm_ss") + ".json";
        Console.WriteLine(fileName);

        try {
            string jsonString = JsonSerializer.Serialize(entries, new JsonSerializerOptions {WriteIndented = true});
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine("Entries saved to file successfully");
        }
        catch {

        }
    }
}