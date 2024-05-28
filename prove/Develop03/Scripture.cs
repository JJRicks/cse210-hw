using System.Data;

class Scripture {
    // constructor setup
    private string Book;
    private int Chapter;
    private List<int> Verses = new List<int>();
    private List<string> VersesText = new List<string>();

    // class-specific stuff
    private List<Word> WordsList = new List<Word>();

    
    public Scripture(string book, int chapter, List<int> verses, List<string> versesText) {
        Book = book; // pass the parameters into the private variables
        Chapter = chapter;
        Verses = verses;
        VersesText = versesText;

        versesToWords(versesText);
    }

    public string returnReference() {
        // return the full reference with book, chapter, and verses properly formatted
    }

    private void versesToWords(List<string> versesText) {
        for (int i = 0; i < versesText.Count(); i++) {
            Word word = new Word(versesText[i], true);
            WordsList.Add(word);
        }
    }


}

