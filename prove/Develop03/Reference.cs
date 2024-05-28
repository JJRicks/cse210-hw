using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

class Reference {
    private List<Scripture> scriptureList = new List<Scripture>();
    public Random random = new Random();
    
    public Reference() {
        // define default scriptures     
        List<int> scripture1list = new List<int> {7};
        List<string> scripture1verses = new List<string> {"And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."};
        Scripture scripture1 = new Scripture("1 Nephi", 3, scripture1list, scripture1verses);

        List<int> scripture2list = new List<int> {7, 8, 9};
        List<string> scripture2verses = new List<string> {"Yea, and there shall be many which shall say: Eat, drink, and be merry, for tomorrow we die; and it shall be well with us.", "And there shall also be many which shall say: Eat, drink, and be merry; nevertheless, fear God—he will justify in committing a little sin; yea, lie a little, take the advantage of one because of his words, dig a pit for thy neighbor; there is no harm in this; and do all these things, for tomorrow we die; and if it so be that we are guilty, God will beat us with a few stripes, and at last we shall be saved in the kingdom of God.", "Yea, and there shall be many which shall teach after this manner, false and vain and foolish doctrines, and shall be puffed up in their hearts, and shall seek deep to hide their counsels from the Lord; and their works shall be in the dark."};
        Scripture scripture2 = new Scripture("2 Nephi", 28, scripture2list, scripture2verses);

        List<int> scripture3list = new List<int> {6, 7};
        List<string> scripture3verses = new List<string> {"Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise. ", "And the Lord God doth work by means to bring about his great and eternal purposes; and by very small means the Lord doth confound the wise and bringeth about the salvation of many souls. "};
        Scripture scripture3 = new Scripture("Alma", 37, scripture3list, scripture3verses);

        scriptureList.Add(scripture1);
        scriptureList.Add(scripture2);
        scriptureList.Add(scripture3);
    }
    
    
    public void addScripture() {
        // get user input to properly set up the scripture, then make a new instance of Scripture, passing all relevant data into the constructor correctly. check input
        string book;
        int chapterNumber;
        string verseRange;
        // as much as I want to do user input validation right now, there's just no time
        
        //Console.Clear();
        Console.WriteLine("Adding a scripture to the database.");
        
        Console.Write("Please type the book name (Alma, 1 Nephi, Helaman, etc...): ");
        book = Console.ReadLine();

        Console.Write("Please type the chapter number (1, 2, 3, etc...): ");
        chapterNumber = int.Parse(Console.ReadLine());

        Console.Write("Please enter the verse range (3-7, 12-18, 1-2, etc...): ");
        verseRange = Console.ReadLine();

        // range list of all verse numbers in the added scripture
        List<int> verses = new List<int>();
        List<string> verseTexts = new List<string>();
        
        // some stupid stuff to get all those verses based off the string
        string[] startAndEndVerseNumbers = verseRange.Split('-');
        int[] startAndEndVerseNumbersInt = [0, 0];
        startAndEndVerseNumbersInt[0] = int.Parse(startAndEndVerseNumbers[0]);
        startAndEndVerseNumbersInt[1] = int.Parse(startAndEndVerseNumbers[1]);

        int numVersesTotal = startAndEndVerseNumbersInt[1] - startAndEndVerseNumbersInt[0] + 1;

        // get the total number of verses, then take the first verse int and add to it to generate a full range list of verses
        for (int i = 0; i < numVersesTotal; i++) {
            verses.Add(startAndEndVerseNumbersInt[0] + i);
        }

        foreach(int num in verses) {
            Console.Write($"Please enter the text for verse {num}: ");
            verseTexts.Add(Console.ReadLine());
        }

        Scripture userAddedScripture = new Scripture(book, chapterNumber, verses, verseTexts);
        scriptureList.Add(userAddedScripture);  
    }
    
    // logic to choose which verses
    public void memorizeScripture(int scriptureNumber, int[] chosenVerses) {
       // nah let's not pull the entire list of lists, just pull one Word list instead.
       // List<List<Word>> listOfVersesContainingWords = scriptureList[scriptureNumber].returnAllVerses();

        // get the specific list of words for the requested verse
        List<List<Word>> requestedVersesList = scriptureList[scriptureNumber].ReturnRequestedVerses(chosenVerses);
        string reference = scriptureList[scriptureNumber].returnReference();
    
        // progressively hide more words
        // TODO, may or may not be necessary
        int willQuitAfterNoVisibleWordsRunsOnce = 0;
        while (true) {
            
            // check visible words and quit if none left
            int visibleWords = 0;
            foreach(List<Word> verse in requestedVersesList) {
                foreach(Word word in verse){
                    if(word.getVisibility() == true) {
                       visibleWords++; 
                    } 
                }
            }
            if (visibleWords == 0) {
                if (willQuitAfterNoVisibleWordsRunsOnce > 0){
                    Console.WriteLine("No visible words, exiting...");
                    return;
                } else {
                    Console.WriteLine($"\n{reference}");
                }
                willQuitAfterNoVisibleWordsRunsOnce++;
            }
            
            // pick the words to be hidden randomly and add them to a list of indicies hidden
            
            List<int> numWordsPerVerse = new List<int>(); // list of ints, each int represents the number of words in each verse
            List<List<int>> hiddenWordIndicies = new List<List<int>>(); // keeps track of all the hidden word numbers in a 2D list

            
            // count the number of words in each verse and add it to the list keeping track of that
            foreach(List<Word> verse in requestedVersesList) {
                int numWordsInThisVerse = 0;
                foreach(Word word in verse) {
                    numWordsInThisVerse++;
                }
                numWordsPerVerse.Add(numWordsInThisVerse);
            }
            
            // pick two random ints to hide based on how many words per verse
            int j = 0;
            foreach(List<Word> verse in requestedVersesList) {
                // add a for loop here to make it easier to handle the case that the second int comes back the same as the first 
                for(int k = 0; k < 2; k++) {
                    int randomlyChosenHiddenWordIndex = random.Next(numWordsPerVerse[0]);
                    // pick another number if the number is already in the list of hidden word indicies
                    while(true) {
                        if (hiddenWordIndicies[k].Contains(randomlyChosenHiddenWordIndex)) {
                            
                        } else {
                            return;
                        }
                    }
                }
                
                
                j++;
            }
            
            
            
            // start pulling from the hide list and set the relevant words to false
            

            // count the number of visible words and exit after running one more time if the number is zero
            
            

            int i = 0;
            // take the requested verses, then check visibility and hide words that are set to false. Then print them out
            foreach(List<Word> verse in requestedVersesList) {
                Console.Write(chosenVerses[i]);
                Console.Write(" ");
                foreach(Word word in verse){
                    if(word.getVisibility() == true) {
                        Console.Write(word.getWord());
                        Console.Write(" ");
                    } else {
                        string obscuredWord = "";
                        foreach(char character in word.getWord()) {
                            obscuredWord += "_";
                        }
                        Console.Write(obscuredWord);
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine("\n");
                
                i++;
            }
        }
        
        
        
        
            
        // print out all the words in the verses

        // foreach(List<Word> verse in listOfVersesContainingWords) {
        //     foreach(Word word in verse){ 
        //         Console.Write($"{word.getWord()} ");
        //     }
        //     Console.WriteLine();
        // }

    }

    
    
    public string listAllScriptures() { // return a string containing the numbered list of all scriptures in the database
        string allScriptures = "";
        for(int i = 0; i < scriptureList.Count(); i++) {
            allScriptures = allScriptures + $"{i + 1}: {scriptureList[i].returnReference()}\n";
        }
        return allScriptures;
    }
}