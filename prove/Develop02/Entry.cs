using System;

class Entry {

    private static int entryTotalCount = 0;
    public int EntryNumber { get; private set; }
    public string Title { get; set;} // TODO add logic to make sure it's not empty/valid on all these
    public string Body { get; set; } 

    public Entry() {
        entryTotalCount++;
        EntryNumber = entryTotalCount;   
    }
}