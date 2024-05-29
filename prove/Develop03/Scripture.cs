using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Scripture {
    // constructor setup
    private string Book;
    private int Chapter;
    private List<int> Verses = new List<int>();
    private List<string> ListOfVersesInReference = new List<string>();
    // class-specific stuff
    private List<List<Word>> nestedWordsList = new List<List<Word>>();
    
    public Scripture(string book, int chapter, List<int> verses, List<string> listOfVersesInReference) {
        Book = book; // pass the parameters into the private variables
        Chapter = chapter;
        Verses = verses;
        ListOfVersesInReference = listOfVersesInReference;
        versesToWords(listOfVersesInReference);
    }
    public List<List<Word>> returnAllVerses() {
        return nestedWordsList;
    }

    public List<int> getVerses() {
        return Verses;
    }

    public string returnReference() {
        // return the full reference with book, chapter, and verses properly formatted
        if (Verses.Count() == 1) {
            return $"{Book} {Chapter}:{Verses[0]}";
        }
        else {
            return $"{Book} {Chapter}:{Verses[0]}-{Verses[Verses.Count() - 1]}";
        }
    }

    public List<List<Word>> ReturnRequestedVerses(int[] requestedVerses) {
        // return the specific verses
        List<List<Word>> versesToReturnList = new List<List<Word>>();
        
        // right now the loop is only checking from the first verse
        // what we need: pipe in the int[] requested verses from the user. Compare that to the int[] list of all verses in the scripture
        // for the numbers that match, and use their list indicies to pull the words list into the other words list 

        foreach(int requestedVerse in requestedVerses) {
            int index = Verses.IndexOf(requestedVerse);

            if (index >= 0) {
                // Console.WriteLine($"Yes! The verse was found at index {index}");
                
            } else {
                // Console.WriteLine("The verse was not found");
                throw new Exception("No such verse was found in the selcted scripture.");
            }
            versesToReturnList.Add(nestedWordsList[index]);
        }
        
        return versesToReturnList; 
        // testing 
        // foreach(List<Word> wordList in versesToReturnList) { 
        //     foreach(Word word in wordList){
        //         Console.WriteLine(word.getWord());
        //     }
        // }
    }

    private void versesToWords(List<string> listOfVersesInReference) {
        // take each full verse in the list of verses for this reference, then split it into a a list<Word> nested in a master list of Word<> lists
        foreach(string fullVerse in listOfVersesInReference) {
            // this one will make a strings list, then convert it to a Word list and throw that in to the associated Word list for the verse
            List<string> wordsInIndividualVerse = fullVerse.Split(' ').ToList();
            // Word list of words in the individual verse, then add this to the list of nestedWordsList
            List<Word> verseWordsList = new List<Word>();
            foreach(string word in wordsInIndividualVerse) {
                Word verseWord = new Word(word, true);
                verseWordsList.Add(verseWord);
            }
            nestedWordsList.Add(verseWordsList);
        }
        // foreach(List<Word> verse in nestedWordsList) {
        //     foreach(Word word in verse){ 
        //         Console.Write($"{word.getWord()} ");
        //     }
        //     Console.WriteLine();
        // }
    }
}

