public class Scripture
{
    private Reference _reference;

    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word w in _words)
        {
            w.IsHidden();

            if (!w.IsHidden())
            {
                visibleWords.Add(w);
            }
            Random random = new Random();
           
             // Hide words randomly
            for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
            {
                int index = random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }

        }
    }
    public string GetDisplayText()
    {
        string displaytext = _reference.GetDisplayText();

        foreach (Word w in _words)
        {
            displaytext += w.GetDisplayText() + "";
            
        }
        return displaytext.TrimEnd();
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}