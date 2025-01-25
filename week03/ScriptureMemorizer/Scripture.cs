class Scripture
{
    private Reference _reference;
    private List<Word> _words = new() {"And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, fi these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy ghost. And by the power of the Holy Ghost ye may know the truth of all things."};

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (Word _words in text)
        {
            
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