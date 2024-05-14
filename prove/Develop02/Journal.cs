using System;
using System.Runtime.CompilerServices;
using System.Text.Json;

class Journal {

    // declare variables
    // entry list



    public void addEntry() {
    // TODO pull from the prompts class, possibly interface with ChatGPT API given time
    // interact with the entries class, add user inputs
    Entry entry = new Entry();
    Console.WriteLine("Insert Prompt Here. "); // TODO maybe fancy up the formatting?
    Console.Write("Journal entry title: ");
    
    // add logic and loop to validate entry title, try catch with get set? is that stupid idk
    entry.Title = Console.ReadLine();

    Console.WriteLine("Journal entry: ");
    entry.Body= Console.ReadLine();




    }

    public void displayEntries() {
        // show a truncated list of all current entries and then 
    }

    // 
}