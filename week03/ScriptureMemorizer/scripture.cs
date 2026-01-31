public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // Constructor: split the verse text into words and create Word objects
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    // Hides a specified number of random visible words
    private Random _random = new Random();
    public void HideRandomWords(int numberToHide)
    {
        //  collect all currently visible words
        List<Word> visibleWords = new List<Word>();
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                visibleWords.Add(w);
            }
        }

       // nothing to hide
        if (visibleWords.Count == 0)
            return;

        
        //  hide 'numberToHide' words randomly
        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();       // hide the word
            visibleWords.RemoveAt(index);     // remove from list so we don't pick it again
        }
    }

    // Returns the display text with hidden words represented appropriately
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";  // include reference at start

        foreach (Word w in _words)
        {
            displayText += w.GetDisplayText() + " ";   // add space between words
        }

        return displayText.TrimEnd();   // remove trailing space
    }

    // Checks if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())   // if any word is visible
            {
                return false;
            }
        }

        return true;  // all words are hidden
    }
}
