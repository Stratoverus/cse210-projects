class Scripture
{
    private Reference _reference;
    private List<Word> _words = new();
    

    public Scripture(Reference reference, string text)
    {
        string[] wordsArray = text.Split(' ');
        _reference = reference;
        foreach (string i in wordsArray)
        {
            _words.Add(new Word(i));
        }
    }
//need to fix infinite loop here if there are less words available
    public void HideRandomWords(int numberToHide)
    {
        Random rng = new();
        int numberHidden = 0;
        while (numberHidden < numberToHide)
        {
            int index = rng.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                numberHidden++;
            }
        }
    }
//This page was helpful to learn to manipulate the strings: https://learn.microsoft.com/en-us/dotnet/csharp/how-to/concatenate-multiple-strings
    public string GetDisplayText()
    {
        string textToDisplay = _reference.GetDisplayText() + " ";
        foreach (Word i in _words)
        {
            textToDisplay += i.GetDisplayText() + " ";
        }
        return textToDisplay;
    }

//Trying to have it display all blank before closing.
    public bool IsCompletelyHidden()
    {
        foreach (Word i in _words)
        {
            if (!i.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}