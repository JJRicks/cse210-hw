using System;

class Entry {

    private static int entryTotalCount = 0;
    public int EntryNumber { get; private set; }
   

    private string title;
    public string Title { 
        get { return title; }
        // make sure what the user inputs is not empty
        set {
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("Title cannot be null or empty");
            }
            title = value;
        }
    } 
    
    
    private string body;
    public string Body { 
        get { return body; } 
        // make sure the entered body text is not empty
        set {
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("Body cannot be null or empty");
            }
            body = value;
        }
    
    } 
    public string Prompt { get; set; }

    public string Date { get; set; }

    public Entry() {  // constructor 
        entryTotalCount++;
        EntryNumber = entryTotalCount;   
    }
}