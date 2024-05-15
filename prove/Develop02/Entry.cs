using System;

class Entry {

    private static int entryTotalCount = 0;
    public int EntryNumber { get; private set; }
    public string Title { get; set;} // TODO add logic to make sure it's not empty/valid on all these (ugh)
    public string Body { get; set; } 
    public string Prompt { get; set; }

    public string Date { get; set; }

    public Entry() {  // constructor 
        entryTotalCount++;
        EntryNumber = entryTotalCount;   
    }
}