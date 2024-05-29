using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

class Reference {
    private List<Scripture> scriptureList = new List<Scripture>();
    public Random random = new Random();

    List<List<int>> hiddenWordIndicies = new List<List<int>> { new List<int>(), new List<int>(), new List<int>(), new List<int>(), new List<int>(), new List<int>(), new List<int>(), new List<int>()}; // keeps track of all the hidden word numbers in a 2D list. I know this is stupid and inefficient but I'm going crazy
    
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
        
        Console.Clear();
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
        
        // int willQuitAfterNoVisibleWordsRunsOnce = 0;
        bool beginHiding = false;
        while (true) {
            Console.Clear();
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
                if (true){ //willQuitAfterNoVisibleWordsRunsOnce > 0
                    int verseIndex2 = 0;
                    int wordIndex2 = 0;
                    foreach(List<Word> verse in requestedVersesList) {
                        foreach(Word word in verse) {
                            // if the index of the loop this time around is contained within the list of words to hide within this verse
                            if(hiddenWordIndicies[verseIndex2].Contains(wordIndex2)){
                                requestedVersesList[verseIndex2][wordIndex2].setVisibility(true);
                            }
                            wordIndex2++;
                        }
                        wordIndex2 = 0;
                        verseIndex2++;
                    }
                    Console.WriteLine("No visible words, exiting...");
                    foreach (List<int> intList in hiddenWordIndicies) {
                        intList.Clear();
                    }
                    return;
                } else {
                    
                }
                //willQuitAfterNoVisibleWordsRunsOnce++;
            } else {
                Console.WriteLine($"\n{reference}");
            }

            List<int> numWordsPerVerse = new List<int>(); // list of ints, each int represents the number of words in each requested verse
            
            // count the number of words in each verse and add it to the list keeping track of that
            foreach(List<Word> verse in requestedVersesList) {
                int numWordsInThisVerse = 0;
                foreach(Word word in verse) {
                    numWordsInThisVerse++;
                }
                numWordsPerVerse.Add(numWordsInThisVerse);
            }
            
            // it starts hiding words too early. Here's a bandaid fix lol
            if (beginHiding) {
                // pick two random ints to hide based on how many words per verse
                int indexInVersesList = 0; // index of which verse, which is the list of words
                foreach(List<Word> verse in requestedVersesList) {
                    // for loop to keep track of the numbers
                    // run it twice to generate the two numbers
                    // pick another number if the number is already in the list of hidden word indicies   
                    for (int x = 0; x < 2; x++) {
                        int randomlyChosenHiddenWordIndex = random.Next(numWordsPerVerse[indexInVersesList]);
                        int timesThrough = 0;
                        while(true) {
                            // this is studid but it works. my N(O) is gonna be garbage
                            if(timesThrough > 200) {
                                break;
                            }
                            if(hiddenWordIndicies[indexInVersesList].Contains(randomlyChosenHiddenWordIndex)) {
                                randomlyChosenHiddenWordIndex = random.Next(numWordsPerVerse[indexInVersesList]);
                                timesThrough++;
                            } else {
                                break;
                            }
                        }
                        if (timesThrough > 200) {
                            // don't add the number
                        } else {
                            hiddenWordIndicies[indexInVersesList].Add(randomlyChosenHiddenWordIndex);
                        }
                    }              
                    // iterate to the next verse
                    indexInVersesList++;
                }
            } else {
                beginHiding = true;
            }
            
            // this will print the randomly generated numbers for purposes of debugging

            // foreach(List<int> hiddenWordIndexList in hiddenWordIndicies) {
            //     foreach(int number in hiddenWordIndexList){
            //         Console.Write($"{number} ");
            //     }
            //     Console.WriteLine();
            // }
            
            // start pulling from the hide list and set the relevant words to false
            int verseIndex = 0;
            int wordIndex = 0;
            // go through each verse and word 

            // somehow deal with the empty lists
            // actually not necessary whatever
            foreach(List<Word> verse in requestedVersesList) {
                foreach(Word word in verse) {
                    // if the index of the loop this time around is contained within the list of words to hide within this verse
                    if(hiddenWordIndicies[verseIndex].Contains(wordIndex)){
                        requestedVersesList[verseIndex][wordIndex].setVisibility(false);
                    }
                    wordIndex++;
                }
                wordIndex = 0;
                verseIndex++;
            }

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
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string willContinue = Console.ReadLine();
            if (willContinue == "quit") {
                Console.Clear();
                return;
            }
        }
    }

    public string listAllScriptures() { // return a string containing the numbered list of all scriptures in the database
        string allScriptures = "";
        for(int i = 0; i < scriptureList.Count(); i++) {
            allScriptures = allScriptures + $"{i + 1}: {scriptureList[i].returnReference()}\n";
        }
        return allScriptures;
    }

    public (int, List<int>) getRandomScripture() { // return an random int for scripture number and just use all the verses
        int randomScriptureNumber = random.Next(scriptureList.Count());
        
        Console.WriteLine(randomScriptureNumber);
        List<int> verses = scriptureList[randomScriptureNumber].getVerses();

        return (randomScriptureNumber, verses);
    }
}