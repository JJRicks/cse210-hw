using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Diagnostics.Tracing;
using System.Security;
using System.IO.Enumeration;
using System.Security.AccessControl;

class Journal {

    // declare variables
    // entry list
    List<Entry> entries = new List<Entry>();
    Prompt entryPrompt = new Prompt();
 
    DateTime theCurrentTime = DateTime.Now;

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
        Console.Write("Enter filename to save as: ");
        string userFileName = Console.ReadLine();
        string fileName = userFileName + "_" + DateTime.Now.ToString("yyyy_M_dd__HH_mm_ss") + ".json";
        try {
            string jsonString = JsonSerializer.Serialize(entries, new JsonSerializerOptions {WriteIndented = true});
            File.WriteAllText(fileName, jsonString);

            Console.WriteLine(fileName + " saved to successfully to " + Directory.GetCurrentDirectory());
        }
        catch {

        }
    }
    public void loadFile() {
        string currentDirectory = Directory.GetCurrentDirectory();
        string[] files = Directory.GetFiles(currentDirectory);
        int fileSelection;
        string jsonString;

        List<string> jsonFilesList = new List<string>();

        foreach (string file in files) {
            if (file.Contains(".json")) {
                jsonFilesList.Add(file);
            }
        }
        while (true) {
            Console.WriteLine("\nPlease select a journal file to load: (1, 2, 3... 0 to exit)");
            for (int i = 0; i < jsonFilesList.Count; i++) {
                Console.WriteLine($"{i + 1}: {jsonFilesList[i]}");
            }
            Console.Write("File number: ");

            try {
                fileSelection = int.Parse(Console.ReadLine());
                jsonString = File.ReadAllText(jsonFilesList[fileSelection - 1]);
                break;
            }
            catch {
                Console.WriteLine("Not a valid file number, please try again.");
            }
        }

        entries = JsonSerializer.Deserialize<List<Entry>>(jsonString);
        Console.WriteLine("Entries loaded successfully.");
    }
}