class Scripture
{
    private Reference _reference;
    // Scripture: And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, fi these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy ghost. And by the power of the Holy Ghost ye may know the truth of all things.
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