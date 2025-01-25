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

    public void HideRandomWords(int numberToHide)
    {
        Random rng = new();
        int numberHidden = 0;
        while (numberHidden < numberToHide)
        {
            int index = rng.Next(_words.Count);
            
        }
            

    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}