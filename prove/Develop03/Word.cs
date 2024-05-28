using System.Threading.Tasks.Dataflow;

class Word {
    private string WordText;
    private bool IsVisible;
    public Word(string wordText, bool isVisible) {
        WordText = wordText;
        IsVisible = isVisible;
    }

    public string getWord() { 
        return WordText;
    }
}